using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE.DTO;
using Infrastructure.Observer;
using Infrastructure.Session;

namespace UI.Mantainers
{
    public partial class FrmManageNominationRules : Form, IObserverForm
    {
        public FrmManageNominationRules()
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
