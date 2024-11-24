using Infrastructure.Observer;
using Infrastructure.Session;
using BE.DTO;

namespace UI.Recognitions
{
    public partial class FrmCheckNominationStatus : Form, IObserverForm
    {
        public FrmCheckNominationStatus()
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
    }
}
