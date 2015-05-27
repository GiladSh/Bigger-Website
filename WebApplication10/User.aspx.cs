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
    public partial class User : System.Web.UI.Page
    {
        public string f_name, l_name, agep;

        protected void Page_Load(object sender, EventArgs e)
        {
            f_name = Session["f_n"].ToString();
            l_name =  Session["l_n"].ToString();
            agep = Session["age"].ToString();
            
            string parti = "";
            if (Request.Form["sub"] != null)
            {
                
                string dbPath = this.MapPath("App_Data/Database41.accdb");
                DAL dal = new DAL(dbPath);
                string id = Request.Form["id"];
                string f_n = Request.Form["first_name"];
                string l_n = Request.Form["last_name"];
                string age = Request.Form["age"];
                string participate = Request.Form["Radio1"].ToString();
                if (participate == "0")
                {
                    parti = "no";
                }
                else if (participate=="1")
                {
                    parti = "yes, in wave surfing ";
                }
                else if (participate == "2")
                {
                    parti = "yes, in wind surfing";
                }
                string password = Request.Form["Password"];
                string strSql = "INSERT INTO Table1(f_name, l_name, age, participate, password) VALUES ('" + f_n + "','" + l_n + "','" + age + "','" + parti + "','" + password + "')";
                bool check = dal.update(strSql);
                if (check)
                    Response.Write("<h1> העדכון בוצע בהצלחה </h1>");
                else
                    Response.Write("<h1> העדכון לא בוצע בהצלחה </h1>");
            }
        }
    }
}