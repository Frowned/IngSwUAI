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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
    }
}
