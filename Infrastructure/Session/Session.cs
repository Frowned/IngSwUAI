using BE.DTO;
using BE.Entities;
using BE.Enums;
using Infrastructure.Interfaces;

namespace Infrastructure.Session
{
    public class Session
    {

        public UserDTO User { get; set; }


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
