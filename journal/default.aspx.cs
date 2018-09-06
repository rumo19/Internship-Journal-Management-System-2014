using journal.DataAccess;
using journal.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace journal
{
    public partial class _default : System.Web.UI.Page
    {
        JournalDataAccess db = new JournalDataAccess();
        CustomsDataAccess cb=new CustomsDataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    string searchid = Request.QueryString["id"].ToString();
                    advancesearch(searchid);
                }

                adminview();
            }

        }

        private void advancesearch(string searchid)
        {
            List<SqlParameter> sqlparams = new List<SqlParameter>();

            sqlparams.Add(new SqlParameter("@search", searchid));


            string query = "select * from journalInfo where Id=@search";


            DataTable dtresult = cb.ExecuteParamerizedSelectCommand(query, CommandType.Text, sqlparams.ToArray());

            if (dtresult != null && dtresult.Rows.Count > 0)
            {
                JournalModel updatejournal = new JournalModel();
                DataRow drResult = dtresult.Rows[0];
                txtId.Text = drResult["Id"].ToString();
                txtTitle.Text = drResult["Title"].ToString();
                txtDes.Text = drResult["Description"].ToString();
                txtSt.Text = drResult["Status"].ToString();

                // if (malebox.Checked)
                //{
                //  malebox.Checked=drResult["gender"];
                //}
                //else if(femalebox.Checked)
                //{
                //femalebox.Checked=drResult["gender"].ToString();
                GridView2.DataSource = dtresult;
                GridView2.DataBind();


                //}
            }
        }
        public void adminview()
        {
             
        
            string query = "select * from journalinfo";
            
           
           
           DataTable dtresult = cb.ExecuteSelectCommand(query, CommandType.Text);

            GridView1.DataSource = dtresult;
            GridView1.DataBind();
        }
        

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            JournalModel journalinfo = new JournalModel();
            int id = 0;
            int.TryParse(txtId.Text, out id);
            journalinfo.Id = id;
            journalinfo.Title = txtTitle.Text;
            journalinfo.Description = txtDes.Text;
            string uploadedfile = FileUploadPanel();
            journalinfo.FilePath = uploadedfile;
            journalinfo.Status = txtSt.Text;
            journalinfo.UploadedDate = DateTime.Now;
            journalinfo.ReviewDate = DateTime.Now;
            if (rbtnYes.Checked)
                journalinfo.IsActive = true;
            else if (rbtnNo.Checked)
                journalinfo.IsActive = false;

           // db.Insert(journalinfo);
            if (id == 0)
                db.Insert(journalinfo);
            else
                db.update(journalinfo);
               
            if (id == 0)
            {
                if (string.IsNullOrEmpty(uploadedfile))
                    db.Insert(journalinfo);

            }
        }


        private string FileUploadPanel()
        {
            string fileName = string.Empty;
            try
            {
                if (FileUpload.HasFile)
                {
                    //create the path to save the file to

                    fileName = Path.Combine(Server.MapPath("~/Files"), FileUpload.FileName);
                    //save the file to our local path
                    FileUpload.SaveAs(fileName);
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return fileName;




        }


    }
}
