using BLL;
using Infrastructure.Interfaces.BLL;
using Infrastructure.Helpers;
using BE.Entities;
using BE.DTO;
using Microsoft.Data.SqlClient;
using Infrastructure.Session;
using UI.Language;

namespace UI
{
    public partial class FrmLogin : Form
    {
        private int attempts = 0;
        private string currentUser = String.Empty;
        IUserBLL _userBLL;
        ILanguageBLL _languageBLL;
        public FrmLogin(IUserBLL userBLL, ILanguageBLL languageBLL)
        {
            InitializeComponent();
            _userBLL = userBLL;
            _languageBLL = languageBLL;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string password = EncryptionHelper.Encrypt(TxtPassword.Text);

            LblError.Visible = false;
            if (currentUser != TxtUsername.Text)
            {
                attempts = 0;
                currentUser = TxtUsername.Text;
            }

            UserDTO? user = _userBLL.GetByUsernameAndPassword(currentUser, password);

            if (user != null)
            {
                // Usuario autenticado correctamente
                SingletonSession.Instancia.Login(user);
                SingletonSession.Instancia.currentLanguage = _languageBLL.GetById(user.LanguageId, true)!;
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                // Usuario o contraseña incorrecta
                attempts++;
                LblError.Text = "Usuario y/o contraseña incorrectos.";
                LblError.Visible = true;

                if (attempts >= 3)
                {
                    // Bloquear al usuario
                    bool isBlocked = _userBLL.Block(currentUser);

                    if(isBlocked)
                        LblError.Text = "Usuario bloqueado.";
                    else
                        LblError.Text = "Usuario y/o contraseña incorrectos.";
                    LblError.Visible = true;
                }
            }
        }
    }
}
