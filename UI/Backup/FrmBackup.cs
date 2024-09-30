using BE.DTO;
using Infrastructure.Interfaces.BLL;
using Infrastructure.Observer;
using Infrastructure.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Backup
{
    public partial class FrmBackup : Form, IObserverForm
    {
        private IBackupBLL backupBLL;
        public FrmBackup(IBackupBLL backupBLL)
        {
            InitializeComponent();
            this.backupBLL = backupBLL;
        }

        public void UpdateLanguage(UserSession session)
        {
            foreach (Control control in this.Controls)
            {
                foreach (TranslationDTO translation in session.currentLanguage.Translations)
                {
                    control.Text = control.Tag != null && control.Tag.ToString() == translation.LabelName ? translation.TranslatedText : control.Text;
                }
            }
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
        }

        private void FrmBackup_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonSession.Instancia.RemoveObserver(this);
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            backupBLL.CreateBackup(ConfigurationManager.AppSettings["DefaultBackupPath"]);
            MessageBox.Show("Se genero el Backup correctamente");
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string ext = System.IO.Path.GetExtension(openFileDialog1.FileName);
            if (ext == ".bak")
            {
                backupBLL.RestoreBackup(openFileDialog1.FileName);
                MessageBox.Show("La base de datos se restauro correctamente");
            }
            else
            {
                MessageBox.Show("El formato del archivo debe ser .bak");
            }
        }
    }
}
