using BE.DTO;
using BE.Entities;
using DAL.Helper;
using Infrastructure.Interfaces.DAL;
using Infrastructure.Session;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PointDAL : IPointDAL
    {
        private readonly DatabaseHelper dbHelper;
        private ICheckDigitDAL checkDigitDAL;

        public PointDAL(ICheckDigitDAL checkDigitDAL)
        {
            dbHelper = new DatabaseHelper();
            this.checkDigitDAL = checkDigitDAL;
        }

        public long ExchangePoints(int productId, long userPoints)
        {
            string query = @"INSERT INTO Transactions (UserId, Points, ProductId, TransactionDate) 
                            VALUES (@UserId, (  SELECT Points FROM Products WHERE Id = @ProductId), @ProductId, @TransactionDate);
                              Update Users SET Points = Points - (SELECT Points FROM Products WHERE Id = @ProductId) WHERE Id = @UserId;
                            SELECT SCOPE_IDENTITY();";
            SqlParameter[] parameters =
            [
                new SqlParameter("@UserId", SingletonSession.Instancia.User.Id),
                new SqlParameter("@ProductId", productId),
                new SqlParameter("@TransactionDate", DateTime.Now)
            ];
            object result = dbHelper.ExecuteScalar(query, CommandType.Text, parameters);

            checkDigitDAL.AddCheckDigit("Transactions", "Id", result.ToString());

            query = @"SELECT Points FROM Users Where Id = @UserId";
            parameters =
            [
                new SqlParameter("@UserId", SingletonSession.Instancia.User.Id)
            ];

            return dbHelper.ExecuteScalar(query, CommandType.Text, parameters);            
        }

        public long GetPointsByUserId(Guid id)
        {
            string query = "SELECT Points FROM Users where Id = @UserId";
            SqlParameter[] parameters = [
                    new SqlParameter("@UserId", id)
                    ];
            return dbHelper.ExecuteScalar(query, CommandType.Text, parameters);
        }

        public IList<TransactionDTO> GetTransactions(bool getAll = false)
        {
            try
            {
                List<TransactionDTO> list = new List<TransactionDTO>();
                string query = $@"SELECT t.Id, u.Username, p.ProductName, t.Points, t.TransactionDate FROM Transactions t
                                    LEFT JOIN Users u ON u.Id = t.UserId
                                    LEFT JOIN Products p ON p.Id = t.ProductId" + (getAll ? string.Empty : " WHERE t.UserId = @UserId");
                SqlParameter[] parameters = getAll ? [] : [
                    new SqlParameter("@UserId", SingletonSession.Instancia.User.Id)
                    ];
                DataSet ds = dbHelper.ExecuteDataSet(query, CommandType.Text, parameters);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        TransactionDTO transaction = new TransactionDTO
                        {
                            Id = int.Parse(dr["Id"].ToString()!),
                            User = dr["Username"].ToString()!,
                            Product = dr["ProductName"].ToString()!,
                            Points = long.Parse(dr["Points"].ToString()!),
                            TransactionDate = DateTime.Parse(dr["TransactionDate"].ToString()!)
                        };
                        list.Add(transaction);
                    }
                    return list.OrderBy(f => f.Id).ToList();
                }
                else
                {
                    return new List<TransactionDTO>();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
