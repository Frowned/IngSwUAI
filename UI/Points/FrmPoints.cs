using BE.DTO;
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

namespace UI.Points
{
    public partial class FrmPoints : Form, IObserverForm
    {
        public FrmPoints()
        {
            InitializeComponent();
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

        private void FrmPoints_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonSession.Instancia.RemoveObserver(this);
        }

        private void FrmPoints_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
        }
    }
}
