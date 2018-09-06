using System;
using journal.DataAccess;
using journal.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace journal
{
    public partial class delete : System.Web.UI.Page
    {
        CustomsDataAccess db = new CustomsDataAccess();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                adminview();
            }
        }
         public void adminview()
        {
             
        
            string query = "select * from journalinfo";
            
           
           
           DataTable dtresult = db.ExecuteSelectCommand(query, CommandType.Text);

            GridView1.DataSource = dtresult;
            GridView1.DataBind();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            JournalModel delete = new JournalModel();
            int anInteger;
            anInteger = Convert.ToInt32(txtId.Text);
            anInteger = int.Parse(txtId.Text);
            delete.Id = anInteger;
                      List<SqlParameter> sqlparams = new List<SqlParameter>();

                      sqlparams.Add(new SqlParameter("@Id", delete.Id));
            
            string query = "DELETE from journalInfo where Id=@Id";
            
            db.ExecuteNonQuery(query, CommandType.Text, sqlparams.ToArray());
            
            adminview();

        }
    }
}