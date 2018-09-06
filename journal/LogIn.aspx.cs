using journal.DataAccess;
using journal.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace journal
{
    public partial class LogIn : System.Web.UI.Page
    {

        public CustomsDataAccess db = new CustomsDataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
       
       protected void btnLogIn_Click(object sender, EventArgs e)
        {

            UserModel login = new UserModel();
            login.UserName = txtUserName.Text;
            login.Password = txtPassword.Text;
            //db.match(login);
            List<SqlParameter> sqlparams = new List<SqlParameter>();

            sqlparams.Add(new SqlParameter("@UserName", login.UserName));
            sqlparams.Add(new SqlParameter("@Password", login.Password));
            //sqlparams.Add(new SqlParameter("@FullName", login.FullName));


            string query = "select * from UserInfo where Username=@Username and Password=@Password";


            DataTable dtresult = db.ExecuteParamerizedSelectCommand(query, CommandType.Text, sqlparams.ToArray());
           
            if (dtresult != null && dtresult.Rows.Count == 1)
            {
               
                //output.Text = dtresult.Rows[0][3].ToString();
               FormsAuthentication.SetAuthCookie("UserName", true);//chkBox.Checked;
               if (User.Identity.IsAuthenticated)
               {
                     //Logged use
               }
               Response.Redirect("~/default.aspx");

            }
            else
            {
                output.Text = "you must login first";

                
            }
        }
    }
}