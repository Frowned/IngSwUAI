using BE.DTO;
using Infrastructure.Observer;
using Infrastructure.Session;

namespace UI.Recognitions
{
    public partial class FrmReviewPendingNominations : Form, IObserverForm
    {
        public FrmReviewPendingNominations()
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
