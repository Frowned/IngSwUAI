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

namespace UI
{
    public partial class FrmPrincipal : Form
    {
        FrmViewProducts? frmViewProducts = null;
        FrmManageProfile? frmManageProfile = null;
        FrmManageLanguage? frmManageLanguage = null;
        FrmAddProducts? frmAddProducts = null;
        ILanguageBLL languageBLL;
        IUserBLL userBLL;
        public FrmPrincipal(ILanguageBLL languageBLL, IUserBLL userBLL)
        {
            this.languageBLL = languageBLL;
            InitializeComponent();
            this.userBLL = userBLL;
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
                    gestionarIdiomaToolStripMenuItem.Enabled= SingletonSession.Instancia.IsInRole(PermissionsType.GESTIONAR_IDIOMA);
                    gestionarObjetivosToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.GESTIONAR_OBJETIVOS);
                    gestionarPerfilesToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.GESTIONAR_PERFIL);
                    gestionarProductosToolStripMenuItem.Enabled = SingletonSession.Instancia.IsInRole(PermissionsType.GESTIONAR_PRODUCTOS);
                    administraciónToolStripMenuItem.Enabled = gestionarEmpleadosToolStripMenuItem.Enabled || gestionarIdiomaToolStripMenuItem.Enabled ||
                        gestionarObjetivosToolStripMenuItem.Enabled || gestionarPerfilesToolStripMenuItem.Enabled || gestionarProductosToolStripMenuItem.Enabled;
                    puntosToolStripMenuItem.Enabled = verProductosToolStripMenuItem.Enabled || consultarPuntosToolStripMenuItem.Enabled || consultarPuntosToolStripMenuItem.Enabled;
                    cerrarSesiónToolStripMenuItem.Visible = true;
                    userToolStrip.Text = $"Usuario {SingletonSession.Instancia.User.Username} conectado";
                }
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmLogout frmLogout = new FrmLogout())
            {
                DialogResult result = frmLogout.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ClearMenu();
                    userToolStrip.Text = $"Usuario (No conectado)";

                }

                CloseForms();
            }
        }

        private void CloseForms()
        {
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

        }

        private void canjearPuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            Interaction.MsgBox("No implementado aún");
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("No implementado aún");
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("No implementado aún");
        }
    }
}
