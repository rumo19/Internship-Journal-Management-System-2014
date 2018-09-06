using journal.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace journal.DataAccess
{
    public class JournalDataAccess
    {
        CustomsDataAccess db = new CustomsDataAccess();
        public JournalDataAccess() { }
        public void Insert(JournalModel model)
        {
            string query = @"INSERT INTO
              journalInfo (Title,Description,FilePath,Status,UploadedDate,ReviewDate,IsActive) 
              VALUES(@Title,@Description,@FilePath,@Status,@UploadedDate,@ReviewDate,@IsActive);";

            List<SqlParameter> sqlparams = new List<SqlParameter>();

            sqlparams.Add(new SqlParameter("@Title", model.Title));
            sqlparams.Add(new SqlParameter("@Description", model.Description));
            sqlparams.Add(new SqlParameter("@FilePath", model.FilePath));

            sqlparams.Add(new SqlParameter("@Status", model.Status));
            sqlparams.Add(new SqlParameter("@UploadedDate", model.UploadedDate));
            sqlparams.Add(new SqlParameter("@ReviewDate", model.ReviewDate));
            sqlparams.Add(new SqlParameter("@IsActive", model.IsActive));

            db.ExecuteNonQuery(query, CommandType.Text, sqlparams.ToArray());

        }
        public void update(JournalModel model)
        {
            string query = @"UPDATE journalInfo SET 
                            Title = @Title,
                             Description=@Description,
                             FilePath=@FilePath,
                             Status=@Status,
                             UploadedDate=@UploadedDate,
                             ReviewDate=@ReviewDate,
                             IsActive=@IsActive
                             WHERE Id = @Id;";
            List<SqlParameter> sqlparams = new List<SqlParameter>();
            sqlparams.Add(new SqlParameter("@Id", model.Id));
            sqlparams.Add(new SqlParameter("@Title", model.Title));
            sqlparams.Add(new SqlParameter("@Description", model.Description));
            sqlparams.Add(new SqlParameter("@FilePath", model.FilePath));

            sqlparams.Add(new SqlParameter("@Status", model.Status));
            sqlparams.Add(new SqlParameter("@UploadedDate", model.UploadedDate));
            sqlparams.Add(new SqlParameter("@ReviewDate", model.ReviewDate));
            sqlparams.Add(new SqlParameter("@IsActive", model.IsActive));

            db.ExecuteNonQuery(query, CommandType.Text, sqlparams.ToArray());


        }
    }
}