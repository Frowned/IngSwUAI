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

namespace UI
{
    public partial class FrmPrincipal : Form
    {
        FrmManageLanguage frmManageLanguage = null;
        ILanguageBLL languageBLL;
        public FrmPrincipal(ILanguageBLL languageBLL)
        {
            this.languageBLL = languageBLL;
            InitializeComponent();
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
                    cambiarIdiomaToolStripMenuItem.Visible =
                    cambiarClaveToolStripMenuItem.Visible =
                    puntosToolStripMenuItem.Visible =
                    administraciónToolStripMenuItem.Visible =
                    reporteríaToolStripMenuItem.Visible =
                    ayudaToolStripMenuItem.Visible =
                    cerrarSesiónToolStripMenuItem.Visible = true;

                    puntosToolStripMenuItem.Visible = SingletonSession.Instancia.IsInRole(PermissionsType.ViewProducts);
                    administraciónToolStripMenuItem.Visible = SingletonSession.Instancia.IsInRole(PermissionsType.IsAdmin);
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
            }
        }

        private void ClearMenu()
        {
            iniciarSesiónToolStripMenuItem.Visible = true;
            cambiarIdiomaToolStripMenuItem.Visible =
            cambiarClaveToolStripMenuItem.Visible =
            puntosToolStripMenuItem.Visible =
            administraciónToolStripMenuItem.Visible =
            reporteríaToolStripMenuItem.Visible =
            ayudaToolStripMenuItem.Visible =
            cerrarSesiónToolStripMenuItem.Visible = false;
        }

        private void gestionarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageLanguage frmManageLanguage = Program.ServiceProvider.GetRequiredService<FrmManageLanguage>();
            frmManageLanguage.MdiParent = this;
            frmManageLanguage.Show();
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
                var languageId = (int)menuItem.Tag;
            }
        }
    }
}
