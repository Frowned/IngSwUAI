using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE.DTO;
using Infrastructure.Interfaces.BLL;
using Infrastructure.Observer;
using Infrastructure.Session;
using UI.Reports;

namespace UI.Logs
{
    public partial class FrmRecognitionLogs : Form, IObserverForm
    {
        private readonly INominationBLL _nominationBLL;

        public FrmRecognitionLogs(INominationBLL nominationBLL)
        {
            _nominationBLL = nominationBLL;
            InitializeComponent();
        }

        private void PopulateRecognitionTypes()
        {
            var categories = _nominationBLL.GetRecognitionCategories();
            cmbType.DataSource = categories;
            cmbType.DisplayMember = "Name";
            cmbType.ValueMember = "Id";
        }

        private void PopulateCollaborators()
        {
            var users = _nominationBLL.GetUsers();
            cmbCollaborator.DataSource = users;
            cmbCollaborator.DisplayMember = "FirstName";
            cmbCollaborator.ValueMember = "Id";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var dateFrom = dtpDateFrom.Value;
            var dateTo = dtpDateTo.Value;
            var collaboratorId = cmbCollaborator.SelectedValue as Guid?;
            var recognitionTypeId = cmbType.SelectedValue as int?;

            var logs = _nominationBLL.GetNominationHistory(dateFrom, dateTo, collaboratorId, recognitionTypeId);
            PopulateLogs(logs);
        }

        private void PopulateLogs(List<NominationHistoryDTO> logs)
        {
            dgvLogs.Rows.Clear();
            foreach (var log in logs)
            {
                dgvLogs.Rows.Add(log.Id, log.NominationId, log.Nominator, log.Nominee, log.Category, log.StatusName, log.CreatedAt);
            }
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

                if (control.HasChildren)
                {
                    UpdateControlTexts(control.Controls, session);
                }
            }
        }

        private void FrmRecognitionLogs_Load(object sender, EventArgs e)
        {
            // Configure DataGridView for logs
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.ReadOnly = true;

            // Add columns to DataGridView for logs
            dgvLogs.Columns.Add("Id", "ID");
            dgvLogs.Columns.Add("NominationId", "Nomination ID");
            dgvLogs.Columns.Add("Nominator", "Nominator");
            dgvLogs.Columns.Add("Nominee", "Nominee");
            dgvLogs.Columns.Add("Category", "Category");
            dgvLogs.Columns.Add("StatusName", "Status");
            dgvLogs.Columns.Add("CreatedAt", "Created At");
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AllowUserToDeleteRows = false;
            // Populate ComboBox for recognition types
            PopulateRecognitionTypes();

            // Populate ComboBox for collaborators
            PopulateCollaborators();

            // Add event handler for search button
            btnSearch.Click += BtnSearch_Click;
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
        }

        private void FrmRecognitionLogs_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonSession.Instancia.RemoveObserver(this);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            PdfExporter.ExportDataGridViewToPdf(dgvLogs, "Reporte de Reconocimientos", "Registro detallado de reconocimientos en el sistema");
        }
    }
}
