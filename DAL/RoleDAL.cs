using BE.Entities;
using DAL.Helper;
using Infrastructure.Interfaces.DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoleDAL : IRoleDAL
    {
        private readonly DatabaseHelper dbHelper;

        public RoleDAL()
        {
            dbHelper = new DatabaseHelper();
        }

        public void Delete(Role role)
        {
            string query = "DELETE FROM Roles WHERE CompositePermissionId = @Id OR PermissionId = @Id;";
            SqlParameter[] parameters =
            [
                new SqlParameter("@Id", role.Id)
            ];
            dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            query = "DELETE FROM Permissions WHERE Id = @Id;";
            dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }

        public RoleComponent? Get(int roleId)
        {
            string query = "SELECT * FROM Permissions WHERE Id = @Id;";
            SqlParameter[] parameters =
            [
                new SqlParameter("@Id", roleId)
            ];
            DataSet ds = dbHelper.ExecuteDataSet(query, CommandType.Text, parameters);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                Role role = new Role
                {
                    Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()!),
                    Name = ds.Tables[0].Rows[0]["Name"].ToString()!,
                    Label = ds.Tables[0].Rows[0]["Label"].ToString()!,
                    Type = ds.Tables[0].Rows[0]["Type"].ToString()!,
                    Children = GetChilds(roleId)
                };
                return role;
            }
            else
            {
                return null;
            }
        }

        public RoleComponent? GetByLabel(string label)
        {
            string query = "SELECT * FROM Permissions WHERE Label = @Label;";
            SqlParameter[] parameters =
            [
                new SqlParameter("@Label", label)
            ];
            DataSet ds = dbHelper.ExecuteDataSet(query, CommandType.Text, parameters);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                Role role = new Role
                {
                    Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()!),
                    Name = ds.Tables[0].Rows[0]["Name"].ToString()!,
                    Label = ds.Tables[0].Rows[0]["Label"].ToString()!,
                    Type = ds.Tables[0].Rows[0]["Type"].ToString()!,
                    Children = GetChilds(int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()!))
                };
                return role;
            }
            else
            {
                return null;
            }
        }

        public List<RoleComponent> GetChilds(int roleId)
        {
            string query = "SELECT p.Name, p.Label, p.Type, r.PermissionId, r.RoleId, r.CompositePermissionId FROM Roles r " +
                           "INNER JOIN Permissions p ON r.PermissionId = p.Id WHERE r.CompositePermissionId = @RoleId;";
            SqlParameter[] parameters =
            [
                new SqlParameter("@RoleId", roleId)
            ];
            DataSet ds = dbHelper.ExecuteDataSet(query, CommandType.Text, parameters);

            List<RoleComponent> children = new List<RoleComponent>();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    RoleComponent roleComponent = new Role
                    {
                        Id = int.Parse(dr["Id"].ToString()!),
                        Name = dr["Name"].ToString()!,
                        Label = dr["Label"].ToString()!,
                        Type = dr["Type"].ToString()!
                    };
                    children.Add(roleComponent);
                }
            }
            return children;
        }

        public int GetLastId()
        {
            string query = "SELECT MAX(Id) AS id_permiso_max FROM Permissions;";
            DataSet ds = dbHelper.ExecuteDataSet(query);
            return int.Parse(ds.Tables[0].Rows[0]["id_permiso_max"].ToString()!);
        }

        public List<RoleComponent> List(bool withChilds = true)
        {
            string query = "SELECT Name, Label, Type, Id FROM Permissions WHERE Type = 'C';";
            DataSet ds = dbHelper.ExecuteDataSet(query);
            List<RoleComponent> roles = new List<RoleComponent>();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    RoleComponent roleComponent = new Role
                    {
                        Id = int.Parse(dr["Id"].ToString()!),
                        Name = dr["Name"].ToString()!,
                        Label = dr["Label"].ToString()!,
                        Type = dr["Type"].ToString()!
                    };
                    if (roleComponent.Type == "C" && withChilds)
                    {
                        roleComponent.Children = GetChilds(roleComponent.Id);
                    }
                    roles.Add(roleComponent);
                }
            }
            return roles;
        }

        public List<RoleComponent> ListSimple()
        {
            throw new NotImplementedException();
        }

        public void Modify(Role role)
        {
            string query = "UPDATE Permissions SET Name = @Name, Label = @Label WHERE Id = @Id;";
            SqlParameter[] parameters =
            [
                new SqlParameter("@Name", role.Name),
                new SqlParameter("@Label", role.Label),
                new SqlParameter("@Id", role.Id)
            ];
            dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            query = "DELETE FROM Roles WHERE CompositePermissionId = @Id OR PermissionId = @Id;";
            parameters =
            [
                new SqlParameter("@Id", role.Id)
            ];
            dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            foreach (RoleComponent child in role.Children)
            {
                query = "INSERT INTO Roles (PermissionId, CompositePermissionId) VALUES (@PermissionId, @CompositePermissionId);";
                parameters =
                [
                    new SqlParameter("@PermissionId", child.Id),
                    new SqlParameter("@CompositePermissionId", role.Id)
                ];
                dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
            }
        }

        public void Save(Role role)
        {
            string query = "INSERT INTO Permissions (Name, Label, Type) VALUES (@Name, @Label, @Type);";
            SqlParameter[] parameters =
            [
                new SqlParameter("@Name", role.Name),
                new SqlParameter("@Label", role.Label),
                new SqlParameter("@Type", role.Type)
            ];
            dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            int lastId = GetLastId();

            foreach (RoleComponent child in role.Children)
            {
                query = "INSERT INTO Roles (PermissionId, CompositePermissionId) VALUES (@PermissionId, @CompositePermissionId);";
                parameters =
                [
                    new SqlParameter("@PermissionId", child.Id),
                    new SqlParameter("@CompositePermissionId", lastId)
                ];
                dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
            }
        }
    }
}
