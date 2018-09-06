using journal.Entities;
using journal.DataAccess;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace journal
{
    public partial class Registration : System.Web.UI.Page
    {
        UserDataAccess db = new UserDataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            UserModel registration = new UserModel();


            if (Page.IsValid)
            {
                registration.UserName = txtUserName.Text;
                registration.Password = txtPassword.Text;
                registration.FullName = txtFullName.Text;
                registration.Email = txtEmail.Text;
                registration.IsActive = false;
                registration.UserType = 3;
               

                db.insert(registration);
            }
           

        }
   
    
    
    
    }
        }
