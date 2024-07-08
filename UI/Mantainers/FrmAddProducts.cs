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
        public FrmAddProducts(IProductBLL productBLL)
        {
            InitializeComponent();
            this.productBLL = productBLL;
            TxtPoints.KeyPress += new KeyPressEventHandler(TxtPoints_KeyPress);
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
            var productDto = new ProductDTO()
            {
                ProductName = TxtName.Text,
                Points = long.Parse(TxtPoints.Text),
                Description = TxtDescription.Text,
                Category = CmbCategories.Text
            };
            productBLL.AddProduct(productDto);
            FillDataSource();
            Interaction.MsgBox("Se dio de alta el producto");
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
            Interaction.MsgBox("Se deshabilitó el producto correctamente");
            ClearInputs();
        }
    }
}
