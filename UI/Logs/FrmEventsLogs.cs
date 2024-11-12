using BE.DTO;
using BE.Entities;
using Infrastructure.Interfaces.BLL;
using Infrastructure.Observer;
using Infrastructure.Session;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.Layout.Borders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iText.Layout.Renderer;
using UI.Reports;

namespace UI.Logs
{
    public partial class FrmEventsLogs : Form, IObserverForm
    {
        private ILogBLL logBLL;

        public FrmEventsLogs(ILogBLL logBLL)
        {
            InitializeComponent();
            this.logBLL = logBLL;
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

        private void FrmEventsLogs_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
            cmbCriticality.DataSource = Enum.GetValues(typeof(LogType));
            List<string> formNames = new List<string>
            {
                "FrmLogin",
                "FrmPrincipal",
                "FrmManageLanguage",
                "FrmManageProfile",
                "FrmAddProducts",
                "FrmPoints",
                "FrmExchangePoints",
                "FrmExchangeBenefits",
                "FrmTransferPoints",
                "FrmViewProducts",
                "FrmBackup",
                "FrmEventsLogs",
                "FrmProductsLogs",
                "FrmInconsistencyManagement"
            };
            cmbModule.Items.Clear();

            foreach (var formName in formNames)
            {
                cmbModule.Items.Add(formName);
            }
        }

        private void FrmEventsLogs_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonSession.Instancia.RemoveObserver(this);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LogType? selectedType = cmbCriticality.SelectedItem as LogType?;
            string selectedModule = cmbModule.SelectedItem?.ToString();
            DateTime? dateFrom = dtpDateFrom.Value != DateTime.MinValue ? dtpDateFrom.Value : (DateTime?)null;
            DateTime? dateTo = dtpDateTo.Value != DateTime.MinValue ? dtpDateTo.Value : (DateTime?)null;

            // Obtener los logs filtrados
            List<LogDTO> logs = logBLL.GetLogs(selectedType, selectedModule, dateFrom, dateTo);

            // Mostrar los logs en el DataGridView
            dataGridView1.DataSource = logs;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            PdfExporter.ExportDataGridViewToPdf(dataGridView1, "Reporte de Eventos", "Registro detallado de eventos en el sistema");
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            Serializer.ExportDataGridViewToJson(dataGridView1);
        }
    }
}
