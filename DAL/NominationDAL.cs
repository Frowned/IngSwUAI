using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using BE.DTO;
using BE.Entities;
using DAL.Helper;
using Infrastructure.Interfaces.DAL;

namespace DAL
{
    public class NominationDAL : INominationDAL
    {
        private readonly DatabaseHelper dbHelper;

        public NominationDAL()
        {
            dbHelper = new DatabaseHelper();
        }

        public void AddNomination(Nomination nomination)
        {
            string query = "INSERT INTO Nominations (NominatorUserId, NomineeUserId, CategoryId, StatusId, Comments, CreatedBy, CreatedAt) VALUES (@NominatorUserId, @NomineeUserId, @CategoryId, @StatusId, @Comments, @CreatedBy, @CreatedAt)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NominatorUserId", nomination.NominatorUserId),
                new SqlParameter("@NomineeUserId", nomination.NomineeUserId),
                new SqlParameter("@CategoryId", nomination.CategoryId),
                new SqlParameter("@StatusId", nomination.StatusId),
                new SqlParameter("@Comments", nomination.Comments),
                new SqlParameter("@CreatedBy", nomination.CreatedBy.Id),
                new SqlParameter("@CreatedAt", nomination.CreatedAt)
            };

            dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT Id, FirstName + ' ' + LastName AS FullName FROM Users";
            DataSet ds = dbHelper.ExecuteDataSet(query, CommandType.Text);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                users.Add(new User
                {
                    Id = row.Field<Guid>("Id"),
                    FirstName = row.Field<string>("FullName")!
                });
            }

            return users;
        }

        public List<RecognitionCategory> GetRecognitionCategories()
        {
            List<RecognitionCategory> categories = new List<RecognitionCategory>();
            string query = "SELECT Id, Name FROM RecognitionCategories";
            DataSet ds = dbHelper.ExecuteDataSet(query, CommandType.Text);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                categories.Add(new RecognitionCategory
                {
                    Id = row.Field<int>("Id"),
                    Name = row.Field<string>("Name")!
                });
            }

            return categories;
        }
    }
}