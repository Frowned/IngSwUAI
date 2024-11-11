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
        ILanguageBLL languageBLL;
        IUserBLL userBLL;
        public FrmPrincipal(ILanguageBLL languageBLL, IUserBLL userBLL)
        {
            this.languageBLL = languageBLL;
            InitializeComponent();
            this.userBLL = userBLL;
            InitializeHelpProvider();
        }

        private void InitializeHelpProvider()
        {
            string helpFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "SIFRE.chm");
            helpProvider.HelpNamespace = helpFilePath;
            ayudaToolStripMenuItem.ToolTipText = "Abre el módulo de ayuda para esta aplicación.";
            iniciarSesiónToolStripMenuItem.ToolTipText = "Inicia sesión en el sistema.";
            cerrarSesiónToolStripMenuItem.ToolTipText = "Cierra la sesión actual.";
            cambiarClaveToolStripMenuItem.ToolTipText = "Cambia tu clave de acceso.";
            administraciónToolStripMenuItem.ToolTipText = "Accede a las opciones de administración.";
            gestionarPerfilesToolStripMenuItem.ToolTipText = "Gestiona los perfiles de usuario.";
            gestionarIdiomaToolStripMenuItem.ToolTipText = "Configura el idioma de la aplicación.";
            gestionarObjetivosToolStripMenuItem.ToolTipText = "Gestiona los objetivos de los empleados.";
            gestionarEmpleadosToolStripMenuItem.ToolTipText = "Administra la información de los empleados.";
            gestionarProductosToolStripMenuItem.ToolTipText = "Gestiona los productos disponibles.";
            gestionarBackupToolStripMenuItem.ToolTipText = "Realiza copias de seguridad de los datos.";
            puntosToolStripMenuItem.ToolTipText = "Accede a las opciones de puntos.";
            consultarPuntosToolStripMenuItem.ToolTipText = "Consulta tus puntos acumulados.";
            canjearPuntosToolStripMenuItem.ToolTipText = "Canjea tus puntos por productos o recompensas.";
            verProductosToolStripMenuItem.ToolTipText = "Visualiza los productos disponibles.";
            bitacoraEventosToolStripMenuItem.ToolTipText = "Consulta la bitácora de eventos del sistema.";
            bitacoraProductosToolStripMenuItem.ToolTipText = "Consulta la bitácora de movimientos de productos.";
            reporteríaToolStripMenuItem.ToolTipText = "Accede a los reportes y estadísticas.";
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ClearMenu();
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmLogin frmLogin = Program.ServiceProvider.GetRequiredService<FrmLogin>())
            {
                DialogResult result = frmLogin.ShowDialog();

                if (result == DialogResult.OK)
                {
                    iniciarSesiónToolStripMenuItem.Visible = false;
                    administraciónToolStripMenuItem.Visible = true;
                    puntosToolStripMenuItem.Visible = true;
                    reporteríaToolStripMenuItem.Visible = true;
                    ayudaToolStripMenuItem.Visible = true;
                    toolStripDropDownButton1.Visible = true;
                    toolStripDropDownButton1.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.CAMBIAR_IDIOMA);
                    cambiarClaveToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.CAMBIAR_CLAVE);
                    canjearPuntosToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.CANJEAR_PUNTOS);
                    consultarPuntosToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.CONSULTAR_PUNTOS);
                    reporteríaToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.VER_REPORTERIA);
                    ayudaToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.VER_AYUDA);
                    verProductosToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.VER_PRODUCTOS);
                    gestionarEmpleadosToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.GESTIONAR_EMPLEADOS);
                    gestionarIdiomaToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.GESTIONAR_IDIOMA);
                    gestionarObjetivosToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.GESTIONAR_OBJETIVOS);
                    gestionarPerfilesToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.GESTIONAR_PERFIL);
                    gestionarProductosToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.GESTIONAR_PRODUCTOS);
                    gestionarBackupToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.GESTIONAR_BACKUP);
                    bitacoraEventosToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.BITACORA_EVENTOS);
                    bitacoraProductosToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.BITACORA_PRODUCTOS);
                    administraciónToolStripMenuItem.Enabled = bitacoraProductosToolStripMenuItem.Enabled || bitacoraEventosToolStripMenuItem.Enabled || gestionarEmpleadosToolStripMenuItem.Enabled || gestionarIdiomaToolStripMenuItem.Enabled ||
                        gestionarObjetivosToolStripMenuItem.Enabled || gestionarPerfilesToolStripMenuItem.Enabled || gestionarProductosToolStripMenuItem.Enabled || gestionarBackupToolStripMenuItem.Enabled;
                    puntosToolStripMenuItem.Enabled = verProductosToolStripMenuItem.Enabled || consultarPuntosToolStripMenuItem.Enabled || consultarPuntosToolStripMenuItem.Enabled;
                    cerrarSesiónToolStripMenuItem.Visible = true;
                    userToolStrip.Text = $"Usuario {SingletonSession.Instancia.User.Username} conectado";

                    SingletonSession.Instancia.AddObserver(this);
                }
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmLogout frmLogout = new FrmLogout())
            {
                SingletonSession.Instancia.AddObserver(frmLogout);
                DialogResult result = frmLogout.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ClearMenu();
                    userToolStrip.Text = $"Usuario (No conectado)";
                }
                SingletonSession.Instancia.RemoveObserver(frmLogout);

                SingletonSession.Instancia.RemoveObserver(this);
                CloseForms();
            }
        }

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
        }

        private void ClearMenu()
        {
            iniciarSesiónToolStripMenuItem.Visible = true;
            cambiarClaveToolStripMenuItem.Visible =
            toolStripDropDownButton1.Visible =
            administraciónToolStripMenuItem.Visible =
            puntosToolStripMenuItem.Visible =
            reporteríaToolStripMenuItem.Visible =
            ayudaToolStripMenuItem.Visible =
            cerrarSesiónToolStripMenuItem.Visible = false;

        }

        private void gestionarPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void gestionarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.DropDownItems.Clear();
            var languages = languageBLL.GetAllLanguages();

            foreach (var language in languages)
            {
                var item = new ToolStripMenuItem(language.Name);
                item.Tag = language.Id;
                item.Click += LanguageItem_Click;
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

        private void consultarPuntosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void canjearPuntosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void gestionarProductosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void gestionarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("No implementado aún");
        }

        private void gestionarObjetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("No implementado aún");
        }

        private void reporteríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider.HelpNamespace);
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("No implementado aún");
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

        private void gestionarBackupToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void bitacoraEventosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void bitacoraProductosToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
