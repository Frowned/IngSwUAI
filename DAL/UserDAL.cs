using DAL.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Interfaces.DAL;
using BE.Entities;
using Infrastructure.Mappers;
using BE.DTO;

namespace DAL
{
    public class UserDAL : IUserDAL
    {
        private DatabaseHelper dbHelper;

        public UserDAL()
        {
            dbHelper = new DatabaseHelper();
        }

        public UserDTO? GetByUsernameAndPassword(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
            SqlParameter[] parameters =
            [
            new SqlParameter("@Username", username),
            new SqlParameter("@Password", password)
            ];

            DataSet ds = dbHelper.ExecuteDataSet(query, CommandType.Text, parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return UsersMapper.MapToUser(ds.Tables[0].Rows[0]);
            else
                return null;
        }

        public bool Block(string username)
        {
            string query = "UPDATE Users SET IsBlocked = @IsBlocked WHERE Username = @Username";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@IsBlocked", 1),
            new SqlParameter("@Username", username)
            };

            int affectedRows = dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
            return affectedRows > 0;
        }
    }
}
