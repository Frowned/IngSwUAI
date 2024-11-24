using Infrastructure.Session;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Login;
using BE.Enums;
using UI.Language;
using Infrastructure.Interfaces.BLL;
using Infrastructure.Observer;
using UI.Profiles;
using Microsoft.VisualBasic;
using UI.Mantainers;
using UI.Points;
using BE.DTO;
using UI.Backup;
using UI.Logs;
using System.Runtime.InteropServices;

namespace UI
{
    public partial class FrmPrincipal : Form, IObserverForm
    {
        FrmViewProducts? frmViewProducts = null;
        FrmManageProfile? frmManageProfile = null;
        FrmManageLanguage? frmManageLanguage = null;
        FrmAddProducts? frmAddProducts = null;
        FrmExchangePoints? frmExchangePoints = null;
        FrmPoints? frmPoints = null;
        FrmBackup? frmBackup = null;
        FrmEventsLogs? frmEventsLogs = null;
        FrmProductsLogs? frmProductsLogs = null;
        FrmTransferPoints? frmTransferPoints = null;
        FrmExchangeBenefits? frmExchangeBenefits = null;
        ILanguageBLL languageBLL;
        IUserBLL userBLL;
        private System.Windows.Forms.Timer clickTimer; // Temporizador para diferenciar entre clic simple y doble

        public FrmPrincipal(ILanguageBLL languageBLL, IUserBLL userBLL)
        {
            Logout = delegate { };
            this.languageBLL = languageBLL;
            InitializeComponent();
            this.userBLL = userBLL;
            InitializeHelpProvider();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(F1_KeyDown!);
            this.AutoScaleMode = AutoScaleMode.None;
            // Configurar el temporizador
            clickTimer = new System.Windows.Forms.Timer();
            clickTimer.Interval = 200; // Tiempo para diferenciar entre clic simple y doble (ajustable)
            clickTimer.Tick += ClickTimer_Tick!;
        }

        private void F1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string helpFilePath = btnAdmin.Visible && btnAdmin.Enabled ? System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "SIFRE-A.chm") : System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "SIFRE.chm");
                helpProvider.HelpNamespace = helpFilePath;
                Help.ShowHelp(this, helpProvider.HelpNamespace);
                e.Handled = true;
            }
        }
        private void InitializeHelpProvider()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnHelp, "Abre el módulo de ayuda para esta aplicación.");
            toolTip.SetToolTip(btnAdmin, "Accede a las opciones de administración.");
            toolTip.SetToolTip(btnPoints, "Accede a las opciones de puntos.");
            toolTip.SetToolTip(btnProducts, "Accede a las opciones de productos.");
            toolTip.SetToolTip(btnReport, "Accede a las opciones de reportes y estadísticas.");
            toolTip.SetToolTip(btnLogout, "Cierra la sesión actual.");
            toolTip.SetToolTip(btnClose, "Cierra la aplicación.");
            toolTip.SetToolTip(btnMaximizeRestore, "Maximiza o restaura la ventana.");
            toolTip.SetToolTip(btnMinimize, "Minimiza la ventana.");
            toolTip.SetToolTip(btnManageRoles, "Gestiona los perfiles de usuario.");
            toolTip.SetToolTip(btnManageLang, "Configura el idioma de la aplicación.");
            toolTip.SetToolTip(btnManageProducts, "Gestiona los productos disponibles.");
            toolTip.SetToolTip(btnManageBackup, "Realiza copias de seguridad de los datos.");
            toolTip.SetToolTip(btnCheckPoints, "Consulta tus puntos acumulados.");
            toolTip.SetToolTip(btnExchangePoints, "Canjea tus puntos por productos o recompensas.");
            toolTip.SetToolTip(btnViewProducts, "Visualiza los productos disponibles.");
            toolTip.SetToolTip(btnReportEvents, "Consulta la bitácora de eventos del sistema.");
            toolTip.SetToolTip(btnReportProducts, "Consulta la bitácora de movimientos de productos.");
            toolTip.SetToolTip(btnTransferPoints, "Transfiere puntos a otro colaborador.");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        public void Login()
        {
            btnManageLang.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.CAMBIAR_IDIOMA);
            btnTransferPoints.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.CANJEAR_PUNTOS);
            btnExchangePoints.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.CANJEAR_PUNTOS);
            btnCheckPoints.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.CONSULTAR_PUNTOS);
            btnReport.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.VER_REPORTERIA);
            btnHelp.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.VER_AYUDA);
            btnViewProducts.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.VER_PRODUCTOS);
            btnManageLang.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.GESTIONAR_IDIOMA);
            btnManageRoles.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.GESTIONAR_PERFIL);
            btnManageProducts.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.GESTIONAR_PRODUCTOS);
            btnManageBackup.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.GESTIONAR_BACKUP);
            btnReportEvents.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.BITACORA_EVENTOS);
            btnReportProducts.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.BITACORA_PRODUCTOS);

            btnAdmin.Visible = btnManageLang.Enabled || btnManageRoles.Enabled || btnManageProducts.Enabled || btnManageBackup.Enabled || btnReportEvents.Enabled || btnReportProducts.Enabled;
            btnPoints.Visible = btnCheckPoints.Enabled || btnExchangePoints.Enabled || btnTransferPoints.Enabled;
            btnProducts.Visible = btnViewProducts.Enabled;
            btnReport.Visible = btnReportEvents.Enabled || btnReportProducts.Enabled;

            btnLogout.Visible = true;
            userToolStrip.Text = $"Usuario {SingletonSession.Instancia.User.Username} conectado";
            string helpFilePath = btnAdmin.Enabled ? System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "SIFRE-A.chm") : System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "SIFRE.chm");
            helpProvider.HelpNamespace = helpFilePath;

            SingletonSession.Instancia.AddObserver(this);
        }
        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmLogin frmLogin = Program.ServiceProvider.GetRequiredService<FrmLogin>())
            {
                DialogResult result = frmLogin.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Login();
                }
            }
        }

        public event EventHandler Logout;

        private void CloseForms()
        {
            if (frmBackup != null)
            {
                frmBackup.Dispose();
                frmBackup.Close();
                frmBackup = null;
            }
            if (frmProductsLogs != null)
            {
                frmProductsLogs.Dispose();
                frmProductsLogs.Close();
                frmProductsLogs = null;
            }
            if (frmEventsLogs != null)
            {
                frmEventsLogs.Dispose();
                frmEventsLogs.Close();
                frmEventsLogs = null;
            }
            if (frmManageLanguage != null)
            {
                frmManageLanguage.Dispose();
                frmManageLanguage.Close();
                frmManageLanguage = null;
            }
            if (frmManageProfile != null)
            {
                frmManageProfile.Dispose();
                frmManageProfile.Close();
                frmManageProfile = null;
            }
            if (frmAddProducts != null)
            {
                frmAddProducts.Dispose();
                frmAddProducts.Close();
                frmAddProducts = null;
            }
            if (frmViewProducts != null)
            {
                frmViewProducts.Dispose();
                frmViewProducts.Close();
                frmViewProducts = null;
            }
            if (frmExchangePoints != null)
            {
                frmExchangePoints.Dispose();
                frmExchangePoints.Close();
                frmExchangePoints = null;
            }
            if (frmPoints != null)
            {
                frmPoints.Dispose();
                frmPoints.Close();
                frmPoints = null;
            }
            if (frmTransferPoints != null)
            {
                frmTransferPoints.Dispose();
                frmTransferPoints.Close();
                frmTransferPoints = null;
            }
            if (frmExchangeBenefits != null)
            {
                frmExchangeBenefits.Dispose();
                frmExchangeBenefits.Close();
                frmExchangeBenefits = null;
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.DropDownItems.Clear();
            var languages = languageBLL.GetAllLanguages();

            foreach (var language in languages)
            {
                var item = new ToolStripMenuItem(language.Name);
                item.Tag = language.Id;
                item.Click += LanguageItem_Click!;
                toolStripDropDownButton1.DropDownItems.Add(item);
            }
        }

        private void LanguageItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                var languageId = (int)menuItem.Tag!;
                if (SingletonSession.Instancia.User != null)
                {
                    SingletonSession.Instancia.currentLanguage = languageBLL.GetById(languageId, true)!;
                    SingletonSession.Instancia.changeLanguage = true;
                    userBLL.UpdateUserLanguage(SingletonSession.Instancia.User.Id, languageId);
                }
            }
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            clickTimer.Stop();
            btnMaximizeRestore_Click(sender, e);
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            using (FrmLogout frmLogout = new FrmLogout())
            {
                SingletonSession.Instancia.AddObserver(frmLogout);
                DialogResult result = frmLogout.ShowDialog();

                if (result == DialogResult.OK)
                {
                    HideSubMenu();
                    userToolStrip.Text = $"Usuario (No conectado)";
                    this.Close();
                    Logout.Invoke(sender, e);
                    SingletonSession.Instancia.RemoveObserver(frmLogout);

                    SingletonSession.Instancia.RemoveObserver(this);
                    CloseForms();
                }
            }
        }

        private void HideSubMenu()
        {
            pnlPoints.Visible = false;
            pnlProducts.Visible = false;
            pnlReports.Visible = false;
            pnlAdmin.Visible = false;
        }

        private void ShowSubMenu(Panel pSubMenu)
        {
            if (pSubMenu.Visible == false)
            {
                HideSubMenu();
                pSubMenu.Visible = true;
            }
            else
            {
                pSubMenu.Visible = false;
            }
        }

        #region "Button Clicks"
        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlProducts);
            btnProducts.Visible = btnViewProducts.Enabled; 
        }

        private void btnPoints_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlPoints);
            btnCheckPoints.Visible = btnCheckPoints.Enabled;
            btnExchangePoints.Visible = btnExchangePoints.Enabled;
            btnTransferPoints.Visible = btnTransferPoints.Enabled;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlReports);
            btnReportEvents.Visible = btnReportEvents.Enabled;
            btnReportProducts.Visible = btnReportProducts.Enabled;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlAdmin);
            btnManageLang.Visible = btnManageLang.Enabled;
            btnManageRoles.Visible = btnManageRoles.Enabled;
            btnManageProducts.Visible = btnManageProducts.Enabled;
            btnManageBackup.Visible = btnManageBackup.Enabled;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider.HelpNamespace);
        }

        private void btnManageBackup_Click(object sender, EventArgs e)
        {
            if (frmBackup == null || frmBackup.IsDisposed)
            {
                frmBackup = Program.ServiceProvider.GetRequiredService<FrmBackup>();
                SingletonSession.Instancia.AddObserver(frmBackup);
                frmBackup.MdiParent = this;
                frmBackup.Show();
            }
            else
            {
                frmBackup.BringToFront();
                frmBackup.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            if (frmAddProducts == null || frmAddProducts.IsDisposed)
            {
                frmAddProducts = Program.ServiceProvider.GetRequiredService<FrmAddProducts>();
                SingletonSession.Instancia.AddObserver(frmAddProducts);
                frmAddProducts.MdiParent = this;
                frmAddProducts.Show();
            }
            else
            {
                frmAddProducts.BringToFront();
                frmAddProducts.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnManageLang_Click(object sender, EventArgs e)
        {
            if (frmManageLanguage == null || frmManageLanguage.IsDisposed)
            {
                frmManageLanguage = Program.ServiceProvider.GetRequiredService<FrmManageLanguage>();
                SingletonSession.Instancia.AddObserver(frmManageLanguage);
                frmManageLanguage.MdiParent = this;
                frmManageLanguage.Show();
            }
            else
            {
                frmManageLanguage.BringToFront();
                frmManageLanguage.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnManageRoles_Click(object sender, EventArgs e)
        {
            if (frmManageProfile == null || frmManageProfile.IsDisposed)
            {
                frmManageProfile = Program.ServiceProvider.GetRequiredService<FrmManageProfile>();
                SingletonSession.Instancia.AddObserver(frmManageProfile);
                frmManageProfile.MdiParent = this;
                frmManageProfile.Show();
            }
            else
            {
                frmManageProfile.BringToFront();
                frmManageProfile.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnReportProducts_Click(object sender, EventArgs e)
        {
            if (frmProductsLogs == null || frmProductsLogs.IsDisposed)
            {
                frmProductsLogs = Program.ServiceProvider.GetRequiredService<FrmProductsLogs>();
                SingletonSession.Instancia.AddObserver(frmProductsLogs);
                frmProductsLogs.MdiParent = this;
                frmProductsLogs.Show();
            }
            else
            {
                frmProductsLogs.BringToFront();
                frmProductsLogs.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnReportEvents_Click(object sender, EventArgs e)
        {
            if (frmEventsLogs == null || frmEventsLogs.IsDisposed)
            {
                frmEventsLogs = Program.ServiceProvider.GetRequiredService<FrmEventsLogs>();
                SingletonSession.Instancia.AddObserver(frmEventsLogs);
                frmEventsLogs.MdiParent = this;
                frmEventsLogs.Show();
            }
            else
            {
                frmEventsLogs.BringToFront();
                frmEventsLogs.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            if (frmViewProducts == null || frmViewProducts.IsDisposed)
            {
                frmViewProducts = Program.ServiceProvider.GetRequiredService<FrmViewProducts>();
                SingletonSession.Instancia.AddObserver(frmViewProducts);
                frmViewProducts.MdiParent = this;
                frmViewProducts.Show();
            }
            else
            {
                frmViewProducts.BringToFront();
                frmViewProducts.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnTransferPoints_Click(object sender, EventArgs e)
        {
            if (frmTransferPoints == null || frmTransferPoints.IsDisposed)
            {
                frmTransferPoints = Program.ServiceProvider.GetRequiredService<FrmTransferPoints>();
                SingletonSession.Instancia.AddObserver(frmTransferPoints);
                frmTransferPoints.MdiParent = this;
                frmTransferPoints.Show();
            }
            else
            {
                frmTransferPoints.BringToFront();
                frmTransferPoints.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnExchangePoints_Click(object sender, EventArgs e)
        {
            if (frmExchangePoints == null || frmExchangePoints.IsDisposed)
            {
                frmExchangePoints = Program.ServiceProvider.GetRequiredService<FrmExchangePoints>();
                SingletonSession.Instancia.AddObserver(frmExchangePoints);
                frmExchangePoints.MdiParent = this;
                frmExchangePoints.Show();
            }
            else
            {
                frmExchangePoints.BringToFront();
                frmExchangePoints.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnCheckPoints_Click(object sender, EventArgs e)
        {
            if (frmPoints == null || frmPoints.IsDisposed)
            {
                frmPoints = Program.ServiceProvider.GetRequiredService<FrmPoints>();
                SingletonSession.Instancia.AddObserver(frmPoints);
                frmPoints.MdiParent = this;
                frmPoints.Show();
            }
            else
            {
                frmPoints.BringToFront();
                frmPoints.WindowState = FormWindowState.Maximized;
            }
        }
        #endregion

        #region "Utils"
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                clickTimer.Start();
            }
        }
        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            // Si no ocurre un doble clic, ejecutar el movimiento del formulario
            clickTimer.Stop();
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void UpdateLanguage(UserSession session)
        {
            UpdateControlTexts(this.Controls, session);
        }
        private void UpdateControlTexts(Control.ControlCollection controls, UserSession session)
        {
            foreach (Control control in controls)
            {
                foreach (TranslationDTO translation in session.currentLanguage.Translations)
                {
                    if (control.Tag != null && control.Tag.ToString() == translation.LabelName)
                    {
                        control.Text = translation.TranslatedText;
                    }
                }

                if (control is MenuStrip menuStrip)
                {
                    UpdateMenuStripItems(menuStrip.Items, session);
                }

                if (control.HasChildren)
                {
                    UpdateControlTexts(control.Controls, session);
                }
            }
        }
        private void UpdateMenuStripItems(ToolStripItemCollection items, UserSession session)
        {
            foreach (ToolStripItem item in items)
            {
                foreach (TranslationDTO translation in session.currentLanguage.Translations)
                {
                    if (item.Tag != null && item.Tag.ToString() == translation.LabelName)
                    {
                        item.Text = translation.TranslatedText;
                    }
                }

                if (item is ToolStripMenuItem toolStripMenuItem)
                {
                    UpdateMenuStripItems(toolStripMenuItem.DropDownItems, session);
                }
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMaximizeRestore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximizeRestore.Text = "🗗";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximizeRestore.Text = "🗖";
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            btnLogout_Click(sender, e);
        }
        #endregion

    }
}
