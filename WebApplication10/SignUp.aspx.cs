using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
namespace WebApplication10
{
    public partial class SignUp : System.Web.UI.Page
    {
        public string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = (string)Session["id"];
            string dbPath = this.MapPath("App_Data/Database41.accdb");
            DAL dal = new DAL(dbPath);
            if (Request["sub"] != null)
            {
              if (Request["hid"] == "V")
                {

                    string strsql = "INSERT INTO Table1 VALUES ('" + Request["ID"] + "','" + Request["first_name"] + "', '" + Request["last_name"] + "', '" + Request["age"] + "', 'no', '" + Request["Password1"] + "', 'user')";
                    dal.insert(strsql);
                    Response.Redirect("login.aspx");
                }
                else
                {
                    Response.Redirect("SignUp.aspx");
                }
            }
        }
    }
}