using journal.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace journal.DataAccess
{
    public class UserDataAccess
    {
        public CustomsDataAccess db = new CustomsDataAccess();
        public UserDataAccess() { }
        public void insert(UserModel user)
        {

          
            string query = @"INSERT INTO UserInfof (Username,Password,Email,FullName,UserType,IsActive) 
                     VALUES(@Username,@Password,@Email,@FullName,@UserType,@IsActive);";
            List<SqlParameter> sqlparams = new List<SqlParameter>();
            sqlparams.Add(new SqlParameter("@UserName",user.UserName ));
            sqlparams.Add(new SqlParameter("@Password", user.Password));
            sqlparams.Add(new SqlParameter("@Email", user.Email));

            sqlparams.Add(new SqlParameter("@FullName", user.FullName));
            sqlparams.Add(new SqlParameter("@UserType", user.UserType));
            sqlparams.Add(new SqlParameter("@IsActive", user.IsActive));
            
            db.ExecuteNonQuery(query, CommandType.Text, sqlparams.ToArray());

        }
        public void match(UserModel user)
        {
            List<SqlParameter> sqlparams = new List<SqlParameter>();

            sqlparams.Add(new SqlParameter("@UserName", user.UserName));
            sqlparams.Add(new SqlParameter("@Password", user.Password));


            string query = "select * from UserInfo where Username=@Username and Password=@Password and IsActive=true";


        DataTable dtresult= db.ExecuteParamerizedSelectCommand(query, CommandType.Text, sqlparams.ToArray());

            
        }
       
    }
}