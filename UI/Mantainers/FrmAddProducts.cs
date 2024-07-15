using BE.DTO;
using Infrastructure.Interfaces.BLL;
using Infrastructure.Observer;
using Infrastructure.Session;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Mantainers
{
    public partial class FrmAddProducts : Form, IObserverForm
    {
        private IProductBLL productBLL;
        private ILanguageBLL languageBLL;
        public FrmAddProducts(IProductBLL productBLL, ILanguageBLL languageBLL)
        {
            InitializeComponent();
            this.productBLL = productBLL;
            TxtPoints.KeyPress += new KeyPressEventHandler(TxtPoints_KeyPress);
            this.languageBLL = languageBLL;
        }

        private void FrmAddProducts_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
            FillDataSource();
            DgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FillDataSource()
        {
            CmbCategories.DataSource = productBLL.GetCategories();
            DgvProducts.DataSource = productBLL.GetProducts();
        }

        private void FrmAddProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonSession.Instancia.RemoveObserver(this);
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

        private void TxtPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text) ||
                string.IsNullOrWhiteSpace(TxtPoints.Text) ||
                string.IsNullOrWhiteSpace(TxtDescription.Text) ||
                string.IsNullOrWhiteSpace(CmbCategories.Text))
            {
                Interaction.MsgBox(languageBLL.GetByLabel(SingletonSession.Instancia.User.LanguageId, "ALL_REQUIRED") ?? "Todos los campos son obligatorios.", MsgBoxStyle.Critical, "Error");
                return;
            }

            if (!long.TryParse(TxtPoints.Text, out long points))
            {
                Interaction.MsgBox(languageBLL.GetByLabel(SingletonSession.Instancia.User.LanguageId, "VALID_POINTS") ?? "El campo de puntos debe ser un número válido.", MsgBoxStyle.Critical, "Error");
                return;
            }

            var productDto = new ProductDTO()
            {
                ProductName = TxtName.Text,
                Points = points,
                Description = TxtDescription.Text,
                Category = CmbCategories.Text
            };

            productBLL.AddProduct(productDto);
            FillDataSource();
            Interaction.MsgBox(languageBLL.GetByLabel(SingletonSession.Instancia.User.LanguageId, "ADDED_PRODUCT") ?? "Se dio de alta el producto", MsgBoxStyle.Information, languageBLL.GetByLabel(SingletonSession.Instancia.User.LanguageId, "SUCCESS") ?? "Éxito");
            ClearInputs();
        }


        private void ClearInputs()
        {
            TxtDescription.Text = string.Empty;
            TxtName.Text = string.Empty;
            TxtPoints.Text = string.Empty;
            CmbCategories.SelectedIndex = 0;
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = DgvProducts.SelectedRows[0];
            productBLL.DeleteProduct(int.Parse(selectedRow.Cells["Id"].Value.ToString()));
            FillDataSource();
            Interaction.MsgBox(languageBLL.GetByLabel(SingletonSession.Instancia.User.LanguageId, "DISABLED_PRODUCT") ?? "Se deshabilitó el producto correctamente");
            ClearInputs();
        }
    }
}
