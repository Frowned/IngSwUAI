using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Infrastructure.Observer;
using Infrastructure.Session;
using BE.DTO;
using Infrastructure.Interfaces.BLL;
using BE.Entities;
using Infrastructure.Mappers;

namespace UI.Recognitions
{
    public partial class FrmNominateCollaborator : Form, IObserverForm
    {
        private readonly INominationBLL _nominationBLL;
        private readonly ILogBLL _logBLL;

        public FrmNominateCollaborator(INominationBLL nominationBLL, ILogBLL logBLL)
        {
            _nominationBLL = nominationBLL;
            _logBLL = logBLL;
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Populate ComboBoxes with data
            PopulateComboBoxWithUsers(cmbNominee);
            PopulateComboBoxWithCategories(cmbCategory);

        }

        private void PopulateComboBoxWithUsers(ComboBox comboBox)
        {
            var users = _nominationBLL.GetUsers().Where(u => u.Id != SingletonSession.Instancia.User.Id).ToList();
            comboBox.DataSource = users;
            comboBox.DisplayMember = "FirstName";
            comboBox.ValueMember = "Id";
        }

        private void PopulateComboBoxWithCategories(ComboBox comboBox)
        {
            var categories = _nominationBLL.GetRecognitionCategories();
            comboBox.DataSource = categories;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }

        private void SubmitNomination()
        {
            // Validations
            if (cmbNominee.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un colaborador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una categoría de reconocimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbComments.Text))
            {
                MessageBox.Show("Por favor, ingrese comentarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nomination = new Nomination
            {
                NominatorUserId = SingletonSession.Instancia.User.Id,
                NomineeUserId = (Guid)cmbNominee.SelectedValue!,
                CategoryId = (int)cmbCategory.SelectedValue!,
                Comments = rtbComments.Text,
                CreatedBy = UsersMapper.DtoToUser(SingletonSession.Instancia.User)
            };

            try
            {
                _nominationBLL.NominateCollaborator(nomination);
                MessageBox.Show("Nominación enviada con éxito.");

                // Log the nomination
                _logBLL.Save(new BE.Entities.Log
                {
                    Message = $"Nominación enviada para el colaborador {cmbNominee.Text} en la categoría {cmbCategory.Text}.",
                    CreatedAt = DateTime.Now,
                    CreatedBy = UsersMapper.DtoToUser(SingletonSession.Instancia.User),
                    Type = BE.Entities.LogType.Info,
                    Module = this.Name
                });
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar la nominación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearControls()
        {
            cmbNominee.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            rtbComments.Clear();
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

        private void FrmNominateCollaborator_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
        }

        private void btnAddNominee_Click(object sender, EventArgs e)
        {
            SubmitNomination();
        }

        private void btnClearControls_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void FrmNominateCollaborator_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonSession.Instancia.RemoveObserver(this);
        }
    }
}