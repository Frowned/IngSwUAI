using BE.DTO;
using BE.Entities;
using BLL;
using Infrastructure.Interfaces.BLL;
using Infrastructure.Mappers;
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
using Microsoft.VisualBasic;

namespace UI.Language
{
    public partial class FrmManageLanguage : Form
    {
        ILanguageBLL languageBLL;
        ILogBLL logBLL;
        List<Translation> translations = new List<Translation>();
        List<LanguageDTO> languages = new List<LanguageDTO>();
        List<BE.Entities.Label> labels = new List<BE.Entities.Label>();
        BE.Entities.Language? language = null;
        public FrmManageLanguage(ILanguageBLL languageBLL, ILogBLL logBLL)
        {
            InitializeComponent();
            this.languageBLL = languageBLL;
            this.logBLL = logBLL;
        }

        private void FrmAddLanguage_Load(object sender, EventArgs e)
        {
            DgvLabels.SelectionMode =
            DgvTranslations.SelectionMode =
            DgvLanguages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FillDataSource();
        }

        private void FillDataSource()
        {
            languages = languageBLL.GetAllLanguages();
            DgvLanguages.DataSource = languages;
            labels = languageBLL.GetLabels();
            DgvLabels.DataSource = labels;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtLanguage.Text))
            {
                LblError.Visible = true;
                LblError.Text = "El idioma no puede estar en blanco";
            }
            else
            {
                LblError.Visible = false;
                var langAux = languages.FirstOrDefault(f => f.Name == TxtLanguage.Text);
                if (langAux != null)
                {
                    languageBLL.Delete(langAux.Id);
                    LblError.Visible = false;
                    logBLL.Save(new BE.Entities.Log
                    {
                        Message = $"Se borró el idioma {TxtLanguage.Text}",
                        CreatedAt = DateTime.Now,
                        CreatedBy = UsersMapper.DtoToUser(SingletonSession.Instancia.User),
                        Type = BE.Entities.LogType.Info
                    });
                    FillDataSource();
                }
                else
                {
                    LblError.Visible = true;
                    LblError.Text = "El idioma no fue encontrado";

                }

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtLanguage.Text))
            {
                LblError.Visible = true;
                LblError.Text = "El idioma no puede estar en blanco";
            }
            else
            {
                LblError.Visible = false;
                var langAux = languages.FirstOrDefault(f => f.Name == TxtLanguage.Text);
                if (langAux != null)
                {
                    LblError.Visible = true;
                    LblError.Text = "El idioma ya existe";
                }
                else
                {
                    LblError.Visible = false;
                    languageBLL.Save(new LanguageDTO(TxtLanguage.Text));
                    logBLL.Save(new BE.Entities.Log
                    {
                        Message = $"Se creó el idioma {TxtLanguage.Text}",
                        CreatedAt = DateTime.Now,
                        CreatedBy = UsersMapper.DtoToUser(SingletonSession.Instancia.User),
                        Type = BE.Entities.LogType.Info
                    });
                    FillDataSource();
                }

            }

        }

        private void DgvLanguages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLanguages.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DgvLanguages.SelectedRows[0];

                TxtLanguage.Text = selectedRow.Cells["Name"].Value.ToString();
                int languageId = int.Parse(selectedRow.Cells["Id"].Value.ToString()!);
                translations = languageBLL.GetAllTranslations(languageId);
                DgvTranslations.DataSource = translations;

            }
        }

        private void DgvLabels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvLabels.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DgvLabels.SelectedRows[0];

                TxtLabel.Text = selectedRow.Cells["Name"].Value.ToString();
            }
        }

        private void BtnAddLabel_Click(object sender, EventArgs e)
        {
            if (language == null)
            {
                LblError.Text = "No hay ningún idioma seleccionado";
                LblError.Visible = true;
            }
            else
            {
                LblError.Visible = false;
                string label = Interaction.InputBox("Agregue la etiqueta", Title: "Agregar etiqueta");
                string translatedText = Interaction.InputBox("Agregue la traducción", Title: "Agregar traducción");

            }

        }

        private void BtnRemoveLabel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtLabel.Text))
            {
                LblError.Visible = true;
                LblError.Text = "La etiqueta no puede estar en blanco";
            }
            else
            {
                LblError.Visible = false;
                if (languageBLL.LabelExists(TxtLabel.Text))
                {
                    BE.Entities.Label auxLabel = labels.First(label => label.Name == TxtLabel.Text);
                    languageBLL.DeleteLabel(auxLabel.Id);
                    LblError.Visible = false;
                    logBLL.Save(new BE.Entities.Log
                    {
                        Message = $"Se borró la etiqueta {TxtLabel.Text}",
                        CreatedAt = DateTime.Now,
                        CreatedBy = UsersMapper.DtoToUser(SingletonSession.Instancia.User),
                        Type = BE.Entities.LogType.Info
                    });
                    FillDataSource();
                }
                else
                {
                    LblError.Visible = true;
                    LblError.Text = "La etiqueta no fue encontrada";

                }

            }

        }

        private void BtnModifyLabel_Click(object sender, EventArgs e)
        {

        }

        private void BtnModifyTranslation_Click(object sender, EventArgs e)
        {

        }

        private void DgvTranslations_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgvTranslations.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DgvTranslations.SelectedRows[0];

                TxtTranslation.Text = selectedRow.Cells["TranslatedText"].Value.ToString();
            }
        }
    }
}
