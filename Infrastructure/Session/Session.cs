using BE.DTO;
using BE.Entities;
using BE.Enums;
using Infrastructure.Interfaces;
using Infrastructure.Observer;

namespace Infrastructure.Session
{
    public class Session : Subject
    {

        public UserDTO User { get; set; }
        public bool changeLanguage = false;
        private Language _language;
        public Language currentLanguage
        {
            get
            {
                return _language;
            }
            set
            {
                _language = value;
                Notify(_language);
            }
        }


        public void Login(UserDTO usuario)
        {
            User = usuario;
        }

        public void Logout()
        {
            User = null;
        }

        public bool IsLogged()
        {
            return User != null;
        }

        public bool IsInRole(PermissionsType permission)
        {
            if (User == null) return false;

            // Se deja hardcodeado que solo tendrá permiso de Admin
            return permission == PermissionsType.IsAdmin;
        }
    }
}
