using BE.DTO;

namespace Infrastructure.Interfaces.DAL
{
    public interface IUserDAL
    {
        UserDTO? GetByUsernameAndPassword(string username, string password);
        bool Block(string username);
    }
}
