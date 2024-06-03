using BE.DTO;
using BE.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mappers
{
    public static class UsersMapper
    {
        public static UserDTO? MapToUser(DataRow row)
        {
            if (row == null)
                return null;

            return new UserDTO
            {
                Username = row["Username"].ToString(),
                IsBlocked = Convert.ToBoolean(row["IsBlocked"]),
                Email = row["Email"].ToString(),
                FirstName = row["FirstName"].ToString(),
                LastName = row["LastName"].ToString(),
                LanguageId = int.Parse(row["LanguageId"].ToString())
            };
        }
    }

    public class Class1
    {
    }
}
