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
    public partial class login : System.Web.UI.Page
    {
        public DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["sub"] != null)
            {
                //מתבצע קישור למסד הנתונים
                string dbPath = this.MapPath("App_Data/Database41.accdb");
                DAL dal = new DAL(dbPath);
                string strSql;
                //שימוש באוביקט סשין המסוגל להכיל ערך הנשמר לאורך כל הרצת התוכנית- שמירת הערך של הת.ז שהוכנס
                Session["id"] = Request.Form["ID"].ToString();
                Session["pass"] = Request.Form["Pass"].ToString();
                //שימוש בת.ז שהוכנסה לדף זה על ידי משתנה נוסף
                string tmp_id = (string)Session["id"];
                string tmp_pass = (string)Session["pass"];
               
                if (Request["hid"] == "V")
                {
                    if (dal.IsExist("select * from Table1 where ID='" + tmp_id + "' and password='" + tmp_pass + "'"))
                    {
                        //אם כן שלוף את הנתונים של הרשומה שנמצאה ושמור אותם באוביטים מסוג סשין לשימוש עתידי
                        strSql = "Select * from Table1 where id='" + tmp_id + "'";
                        ds = dal.GetData(strSql);

                        foreach (DataRow row in ds.Tables[0].Rows)
                        {

                            Session["f_n"] = row["f_name"].ToString();
                            Session["l_n"] = row["l_name"].ToString();
                            Session["age"] = row["age"].ToString();
                            Session["participate"] = row["participate"].ToString();
                            Session["pass"] = row["password"].ToString();
                            Session["u_t"] = row["user_type"].ToString();
                            if (Session["u_t"].ToString() == "admin")
                            {
                                Response.Redirect("Admin.aspx");
                            }
                            else
                            {
                                Response.Redirect("User.aspx");
                            }
                        }

                    }
                    else
                    {
                        Response.Redirect("SignUp.aspx");
                    }
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}