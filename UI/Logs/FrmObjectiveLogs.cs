using BE.DTO;
using Infrastructure.Interfaces.BLL;
using Infrastructure.Observer;
using Infrastructure.Session;

namespace UI.Logs
{
    public partial class FrmObjectiveLogs : Form, IObserverForm
    {
        private readonly INominationBLL _nominationBLL;
        private readonly IObjectiveBLL _objectiveBLL;

        public FrmObjectiveLogs(INominationBLL nominationBLL, IObjectiveBLL objectiveBLL)
        {
            InitializeComponent();
            _nominationBLL = nominationBLL;
            _objectiveBLL = objectiveBLL;
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

            var logs = _objectiveBLL.GetObjectiveHistory(dateFrom, dateTo, collaboratorId);
            PopulateLogs(logs);
        }

        private void PopulateLogs(List<ObjectiveHistoryDTO> logs)
        {
            dgvLogs.Rows.Clear();
            foreach (var log in logs)
            {
                dgvLogs.Rows.Add(
                    log.Id,
                    log.Collaborator,
                    log.Objective,
                    log.Progress,
                    log.CreatedByName,
                    log.StatusName,
                    log.CreatedAt.ToString("g")
                );
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

        private void FrmObjectiveLogs_Load(object sender, EventArgs e)
        {
            dgvLogs.Columns.Add("Id", "ID");
            dgvLogs.Columns.Add("Collaborator", "Colaborador");
            dgvLogs.Columns.Add("Objective", "Objetivo");
            dgvLogs.Columns.Add("Progress", "Progreso");
            dgvLogs.Columns.Add("CreatedByName", "Creado Por");
            dgvLogs.Columns.Add("StatusName", "Estado");
            dgvLogs.Columns.Add("CreatedAt", "Creado En");
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AllowUserToDeleteRows = false;
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
            PopulateCollaborators();
            btnSearch.Click += BtnSearch_Click;
            
        }

        private void FrmObjectiveLogs_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonSession.Instancia.RemoveObserver(this);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
