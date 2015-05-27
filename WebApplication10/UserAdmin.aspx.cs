using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class UserAdmin : System.Web.UI.Page
    {
        public string idtoupdate, f_nametoupdate, l_nametoupdate, agetoupdate, passwordtoupdate, user_typetoupdate;
        protected void Page_Load(object sender, EventArgs e)
        {
          
            
            idtoupdate = Session["idtoupdate"].ToString();
            f_nametoupdate = Session["f_nametoupdate"].ToString();
            l_nametoupdate = Session["l_nametoupdate"].ToString();
            agetoupdate = Session["agetoupdate"].ToString();
            passwordtoupdate = Session["passwordtoupdate"].ToString();
            user_typetoupdate = Session["user_typetoupdate"].ToString();
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
                else if (participate == "1")
                {
                    parti = "yes, in wave surfing ";
                }
                else if (participate == "2")
                {
                    parti = "yes, in wind surfing";
                }
                string password = Request.Form["Password"];
                string strSql = "INSERT INTO Table1(ID, f_name, l_name, age, participate, password) VALUES ('" + id + "','" + f_n + "','" + l_n + "','" + age + "','" + parti + "','" + password + "')";
                bool check = dal.update(strSql);
                if (check)
                    Response.Write("<h1> העדכון בוצע בהצלחה </h1>");
                else
                    Response.Write("<h1> העדכון לא בוצע בהצלחה </h1>");
            
            }
        }
    }
}