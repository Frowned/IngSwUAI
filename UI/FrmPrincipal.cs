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

namespace UI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
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
                    cerrarSesiónToolStripMenuItem.Visible = true;

                    productosToolStripMenuItem.Visible = SingletonSession.Instancia.IsInRole(PermissionsType.ViewProducts);
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

                if (result == DialogResult.OK){
                    ClearMenu();
                    userToolStrip.Text = $"Usuario (No conectado)";

                }
            }
        }

        private void ClearMenu()
        {
            iniciarSesiónToolStripMenuItem.Visible = true;
            cambiarIdiomaToolStripMenuItem.Visible = 
            cerrarSesiónToolStripMenuItem.Visible = 
            productosToolStripMenuItem.Visible = 
            administraciónToolStripMenuItem.Visible = false;
        }
    }
}
