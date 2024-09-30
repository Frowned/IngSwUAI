using BE.DTO;
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

namespace UI.Logs
{
    public partial class FrmProductsLogs : Form, IObserverForm
    {
        private ILogBLL logBLL;
        public FrmProductsLogs(ILogBLL logBLL)
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

        private void FrmProductsLogs_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
        }

        private void FrmProductsLogs_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonSession.Instancia.RemoveObserver(this);
        }
    }
}
