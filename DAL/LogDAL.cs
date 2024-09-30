using BE.Entities;
using DAL.Helper;
using Infrastructure.Interfaces.DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LogDAL : ILogDAL
    {
        private readonly DatabaseHelper dbHelper;

        public LogDAL()
        {
            dbHelper = new DatabaseHelper();
        }

        public void Save(Log log)
        {
            string query = "INSERT INTO Logs (Message, Type, Module, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) VALUES (@Message, @Type, @Module, @CreatedBy, @CreatedAt, @UpdatedBy, @UpdatedAt);";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Message", log.Message),
                new SqlParameter("@Type", log.Type),
                new SqlParameter("@Module", log.Module),
                new SqlParameter("@CreatedBy", log.CreatedBy != null ? log.CreatedBy.Id : (object)DBNull.Value),
                new SqlParameter("@CreatedAt", log.CreatedAt),
                new SqlParameter("@UpdatedBy", log.UpdatedBy != null ? log.UpdatedBy.Id : (object)DBNull.Value),
                new SqlParameter("@UpdatedAt", log.UpdatedAt != DateTime.MinValue ? log.UpdatedAt : (object)DBNull.Value)
            };

            dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }
    }
}
