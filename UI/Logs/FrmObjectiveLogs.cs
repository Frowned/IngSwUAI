using BE.DTO;
using Infrastructure.Observer;
using Infrastructure.Session;

namespace UI.Logs
{
    public partial class FrmObjectiveLogs : Form, IObserverForm
    {
        public FrmObjectiveLogs()
        {
            InitializeComponent();
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
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
        }

        private void FrmObjectiveLogs_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonSession.Instancia.RemoveObserver(this);
        }
    }
}
