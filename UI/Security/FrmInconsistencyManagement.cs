using Infrastructure.Interfaces.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Security
{
    public partial class FrmInconsistencyManagement : Form
    {
        internal string tableName;
        private IBackupBLL backupBLL;
        private ICheckDigitBLL checkDigitBLL;
        public FrmInconsistencyManagement(IBackupBLL backupBLL, ICheckDigitBLL checkDigitBLL)
        {
            InitializeComponent();
            this.backupBLL = backupBLL;
            this.checkDigitBLL = checkDigitBLL;
        }
        public void Load(string error)
        {
            string[] substring = error.Split('|');
            lblErrorDetailTableName.Text = substring[0];
            lblErrorDetailTableRow.Text = substring[1];
            tableName = substring[2];
        }

        private void BtnRecalculate_Click(object sender, EventArgs e)
        {
            checkDigitBLL.RecalculateTable(tableName, checkDigitBLL.GetIdByTable(tableName));
            MessageBox.Show("Se recalculo la tabla correctamente, vuelva a iniciar sesión");
            this.Close();
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            string ext = System.IO.Path.GetExtension(openFileDialog1.FileName);
            if (ext == ".bak")
            {
                backupBLL.RestoreBackup(openFileDialog1.FileName);
                MessageBox.Show("La base de datos se restauro correctamente, vuelva a iniciar sesión");
                this.Close();
            }
            else
            {
                MessageBox.Show("El formato del archivo debe ser .bak");
            }
        }
    }
}
