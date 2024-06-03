using BE.DTO;
using BE.Entities;

namespace Infrastructure.Interfaces.BLL
{
    public interface IUserBLL
    {
        UserDTO? GetByUsernameAndPassword(string username, string password);
        bool Block(string username);
    }
}
