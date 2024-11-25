using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using BE.DTO;
using DAL.Helper;
using Infrastructure.Interfaces.DAL;

namespace DAL
{
    public class ObjectiveDAL : IObjectiveDAL
    {
        private readonly DatabaseHelper dbHelper;

        public ObjectiveDAL()
        {
            dbHelper = new DatabaseHelper();
        }

        public List<ObjectiveHistoryDTO> GetObjectiveHistory(DateTime dateFrom, DateTime dateTo, Guid? collaboratorId)
        {
            List<ObjectiveHistoryDTO> history = new List<ObjectiveHistoryDTO>();
            string query = @"
        SELECT 
            oh.Id, 
            o.AssignedUserId as CollaboratorId, 
            COALESCE(u.FirstName, '') + ' ' + COALESCE(u.LastName, '') AS Collaborator,
            oh.ObjectiveId, 
            o.Title AS Objective, 
            CAST(oh.Progress AS VARCHAR) AS Progress, 
            oh.CreatedBy, 
            COALESCE(u2.FirstName, '') + ' ' + COALESCE(u2.LastName, '') AS CreatedByName,
            os.Name AS StatusName, 
            oh.CreatedAt
        FROM ObjectiveHistory oh
        INNER JOIN Objectives o ON oh.ObjectiveId = o.Id
        INNER JOIN Users u ON o.AssignedUserId = u.Id
        INNER JOIN Users u2 ON oh.CreatedBy = u2.Id
        INNER JOIN ObjectiveStatuses os ON oh.StatusId = os.Id
        WHERE oh.CreatedAt BETWEEN @DateFrom AND @DateTo";

            if (collaboratorId.HasValue)
            {
                query += " AND o.AssignedUserId = @CollaboratorId";
            }

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@DateFrom", dateFrom),
        new SqlParameter("@DateTo", dateTo),
        collaboratorId.HasValue
            ? new SqlParameter("@CollaboratorId", collaboratorId.Value)
            : new SqlParameter("@CollaboratorId", DBNull.Value)
            };

            DataSet ds = dbHelper.ExecuteDataSet(query, CommandType.Text, parameters);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                history.Add(new ObjectiveHistoryDTO
                {
                    Id = row.Field<int>("Id"),
                    CollaboratorId = row.Field<Guid>("CollaboratorId"),
                    Collaborator = row.Field<string>("Collaborator"),
                    ObjectiveId = row.Field<int>("ObjectiveId"),
                    Objective = row.Field<string>("Objective"),
                    Progress = row.Field<string>("Progress"),
                    CreatedBy = row.Field<Guid>("CreatedBy"),
                    CreatedByName = row.Field<string>("CreatedByName"),
                    StatusName = row.Field<string>("StatusName"),
                    CreatedAt = row.Field<DateTime>("CreatedAt")
                });
            }

            return history;
        }

    }
}