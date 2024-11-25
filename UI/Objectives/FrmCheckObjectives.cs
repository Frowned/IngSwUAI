using Infrastructure.Observer;
using Infrastructure.Session;
using BE.DTO;

namespace UI.Objectives
{
    public partial class FrmCheckObjectives : Form, IObserverForm
    {
        public FrmCheckObjectives()
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

        private void FrmCheckObjectives_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;

        }

        private void FrmCheckObjectives_FormClosed(object sender, FormClosedEventArgs e)
        {

            SingletonSession.Instancia.RemoveObserver(this);
        }
    }
}
