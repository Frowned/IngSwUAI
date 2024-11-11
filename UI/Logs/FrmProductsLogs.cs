using BE.DTO;
using BE.Entities;
using Infrastructure.Interfaces.BLL;
using Infrastructure.Observer;
using Infrastructure.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Reports;

namespace UI.Logs
{
    public partial class FrmProductsLogs : Form, IObserverForm
    {
        private ILogBLL logBLL;
        private bool haveFilter = false;

        public FrmProductsLogs(ILogBLL logBLL)
        {
            InitializeComponent();
            this.logBLL = logBLL;
            dgvProductLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void FrmProductsLogs_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
            haveFilter = false;
            FillGrid();
        }

        private void FrmProductsLogs_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonSession.Instancia.RemoveObserver(this);
        }

        private void FillGrid()
        {
            string productId = textBox1.Text;
            DateTime? dateFrom = dtpDateFrom.Value != DateTime.MinValue ? dtpDateFrom.Value : (DateTime?)null;
            DateTime? dateTo = dtpDateTo.Value != DateTime.MinValue ? dtpDateTo.Value : (DateTime?)null;
            var logs = logBLL.GetLogs(productId, dateFrom, dateTo);
            dgvProductLogs.DataSource = logs;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string productId = textBox1.Text;
            DateTime? dateFrom = dtpDateFrom.Value != DateTime.MinValue ? dtpDateFrom.Value : (DateTime?)null;
            DateTime? dateTo = dtpDateTo.Value != DateTime.MinValue ? dtpDateTo.Value : (DateTime?)null;
            if (dgvProductLogs.SelectedRows.Count > 0)
            {
                int selectedProductId = int.Parse(dgvProductLogs.SelectedRows[0].Cells["ProductId"].Value.ToString());
                logBLL.SetProduct(selectedProductId);
                MessageBox.Show("Producto marcado como activo."); var logs = logBLL.GetLogs(productId, dateFrom, dateTo);
                dgvProductLogs.DataSource = logs;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro.");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            PdfExporter.ExportDataGridViewToPdf(
                dgvProductLogs,               
                "Reporte de Productos",       
                "Listado detallado de productos en el sistema"  
            );
        }
    }
}
