using BE.DTO;
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
    public class LanguageDAL : ILanguageDAL
    {
        private DatabaseHelper dbHelper;
        public LanguageDAL()
        {
            dbHelper = new DatabaseHelper();
        }

        public void Delete(int pLanguageId)
        {
            string query = "DELETE FROM Translations WHERE LanguageId = @LanguageId;";
            SqlParameter[] parameters =
            [
                new SqlParameter("@LanguageId", pLanguageId)
            ];
            dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            query = "DELETE FROM Languages WHERE Id = @LanguageId;";
            dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }

        public Language? Get(string pLanguageName, bool withTranslation = false)
        {
            string query = "SELECT * FROM Languages WHERE Name = @Name;";
            SqlParameter[] parameters =
            [
                new SqlParameter("@Name", pLanguageName)
            ];

            DataSet ds = dbHelper.ExecuteDataSet(query, CommandType.Text, parameters);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                Language language = new Language
                {
                    Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()!),
                    Name = ds.Tables[0].Rows[0]["Name"].ToString()!
                };

                if (withTranslation)
                {
                    language.Translations = ListTranslations(language.Id);
                }

                return language;
            }
            else
            {
                return null;
            }
        }

        public LanguageDTO? GetById(int pLanguageId, bool withTranslation = false)
        {
            string query = "SELECT * FROM Languages WHERE Id = @Id;";
            SqlParameter[] parameters =
            [
                new SqlParameter("@Id", pLanguageId)
            ];

            DataSet ds = dbHelper.ExecuteDataSet(query, CommandType.Text, parameters);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                LanguageDTO language = new LanguageDTO
                {
                    Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()!),
                    Name = ds.Tables[0].Rows[0]["Name"].ToString()!
                };

                if (withTranslation)
                {
                    language.Translations = ListTranslations(language.Id);
                }

                return language;
            }
            else
            {
                return null;
            }
        }

        public int GetLastId()
        {
            string query = "SELECT MAX(Id) AS id_language_max FROM Languages;";
            DataSet ds = dbHelper.ExecuteDataSet(query);
            return int.Parse(ds.Tables[0].Rows[0]["id_language_max"].ToString());
        }

        public List<Translation> ListDefaultTranslation()
        {
            throw new NotImplementedException();
        }

        public List<Translation> ListTranslations(int pLanguageId)
        {
            string query = "SELECT l.Id, l.Name, t.Translation FROM Translations t " +
               "INNER JOIN Languages la ON t.LanguageId = la.Id " +
               "INNER JOIN Labels l ON t.LabelId = l.Id  WHERE la.Id = @LanguageId;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@LanguageId", pLanguageId)
            };

            DataSet ds = dbHelper.ExecuteDataSet(query, CommandType.Text, parameters);
            List<Translation> translations = new List<Translation>();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Translation translation = new Translation
                    {
                        LabelId = int.Parse(dr["Id"].ToString()!),
                        Description = dr["Name"].ToString()!,
                        TranslatedText = dr["Translation"].ToString()!
                    };
                    translations.Add(translation);
                }
            }

            return translations;
        }

        public void Modify(Language pLanguage)
        {
            string query = "UPDATE Languages SET name = @Name WHERE Id = @Id;";
            SqlParameter[] parameters =
            [
                new SqlParameter("@Name", pLanguage.Name),
                new SqlParameter("@Id", pLanguage.Id)
            ];
            dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            if (pLanguage.Translations != null)
            {
                foreach (Translation translation in pLanguage.Translations)
                {
                    query = "UPDATE Translations SET Translation = @Translation WHERE LanguageId = @LanguageId AND LabelId = @LabelId;";
                    parameters =
                    [
                        new SqlParameter("@Translation", translation.TranslatedText),
                        new SqlParameter("@LanguageId", pLanguage.Id),
                        new SqlParameter("@LabelId", translation.LabelId)
                    ];
                    dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
                }
            }
        }

        public void Save(LanguageDTO pLanguage)
        {
            string query = "INSERT INTO Languages (Name) VALUES (@Name);";
            SqlParameter[] parameters =
            [
                new SqlParameter("@Name", pLanguage.Name)
            ];
            dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
            pLanguage.Id = GetLastId();

            if (pLanguage.Translations != null)
            {
                foreach (Translation translation in pLanguage.Translations)
                {
                    query = "INSERT INTO Translations (LanguageId, LabelId, Translation) VALUES (@LanguageId, @LabelId, @Translation);";
                    parameters =
                    [
                        new SqlParameter("@LanguageId", pLanguage.Id),
                        new SqlParameter("@LabelId", translation.LabelId),
                        new SqlParameter("@Translation", translation.TranslatedText)
                    ];
                    dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
                }
            }
        }

        List<LanguageDTO> ILanguageDAL.ListLanguages(bool withTranslation)
        {
            string query = "SELECT * FROM Languages;";
            DataSet ds = dbHelper.ExecuteDataSet(query);
            List<LanguageDTO> languages = new List<LanguageDTO>();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    LanguageDTO language = new LanguageDTO
                    {
                        Id = int.Parse(dr["Id"]!.ToString()!),
                        Name = dr["Name"].ToString()!
                    };

                    if (withTranslation)
                    {
                        language.Translations = ListTranslations(language.Id);
                    }

                    languages.Add(language);
                }
            }

            return languages;

        }

        #region "Labels"
        public bool LabelExists(string labelName)
        {
            string query = "SELECT COUNT(*) FROM Labels WHERE Name = @Name;";
            SqlParameter[] parameters =
            [
        new SqlParameter("@Name", labelName)
            ];

            int count = dbHelper.ExecuteScalar(query, CommandType.Text, parameters);
            return count > 0;
        }
        public void AddLabel(Label label)
        {
            string query = "INSERT INTO Labels (Name) VALUES (@Name);";
            SqlParameter[] parameters =
            [
                new SqlParameter("@Name", label.Name)
            ];
            dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }

        public void DeleteTranslationsByLabelId(int labelId)
        {
            string query = "DELETE FROM Translations WHERE LabelId = @LabelId;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@LabelId", labelId)
            };
            dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }

        public void DeleteLabel(int labelId)
        {
            DeleteTranslationsByLabelId(labelId);

            string query = "DELETE FROM Labels WHERE Id = @Id;";
            SqlParameter[] parameters =
            [
                new SqlParameter("@Id", labelId)
            ];
            dbHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }

        public List<Label> GetLabels()
        {
            string query = "SELECT * FROM Labels;";
            DataSet ds = dbHelper.ExecuteDataSet(query);
            List<Label> labels = new List<Label>();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Label label = new Label()
                    {
                        Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()!),
                        Name = ds.Tables[0].Rows[0]["Name"].ToString()!
                    };
                    labels.Add(label);
                }
            }

            return labels;
        }

        #endregion

    }
}
