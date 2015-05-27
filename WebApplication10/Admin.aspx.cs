using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
namespace AdminUp
{
    public partial class AdminUpdateV2 : System.Web.UI.Page
    {
         
        public DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            string dbPath = this.MapPath("App_Data/Database41.accdb");
            DAL dal = new DAL(dbPath);
            string id = Request["ID"];
            if (!IsPostBack)
            {

                
                string strSql = "Select * from Table1 where ID='" + id + "'";
                ds = dal.GetData(strSql);



                string strSqlGetFullTable = "Select * from Table1";
                DataSet fulltable = dal.GetData(strSqlGetFullTable);
                pagebody.Text += "<table border='5' bordercolor='blue' style='border-radius:10px' cellspacing='5px'><tr><td>id</td><td>first name</td><td>last name</td><td>age</td><td>participation</td><td>password</td><td>user type</td></tr>";

               
                foreach (DataRow row in fulltable.Tables[0].Rows)
                {
                    pagebody.Text += "<tr><td>" + row["ID"] + "</td><td>" + row["f_name"] + "</td><td>" + row["l_name"] + "</td><td>" + row["age"] + "</td><td>" + row["participate"] + "</td><td>" + row["password"] + "<td>" + row["user_type"] + "</td></tr>";

                }
                pagebody.Text += "</table><br />";
            }

                string strSqlDeleteRow = "Delete * from Table1 where id='" + id + "'";
                if (Request["sub"] != null)
                {
                    if (Request["hid"] == "V" && dal.IsExist("select * from Table1 where ID='" + id+"'"))
                    {
                        ds = dal.GetData("select * from Table1 where ID='" + id + "'");
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                Session["idtoupdate"] = row["ID"];
                                Session["f_nametoupdate"] = row["f_name"].ToString();
                                Session["l_nametoupdate"] = row["l_name"].ToString();
                                Session["agetoupdate"] = row["age"].ToString();
                                Session["passwordtoupdate"] = row["password"].ToString();
                                Session["user_typetoupdate"] = row["user_type"].ToString();

                                Response.Redirect("UserAdmin.aspx");
                            }
                            
                        }
                    else if (Request["hid"] == "V" && !dal.IsExist("select * from Table1 where ID='" + id + "'"))
                    {

                        Session["ID"] = Request["ID"];
                        Response.Redirect("SignUp.aspx");
                    }
                    else
                    {
                        
                        Response.Redirect("Admin.aspx");
                    }

                    }
            
    
                
                if (Request["delete"] != null)
                {
                    if (Request["hid"] == "V")
                    {
                        dal.insert(strSqlDeleteRow);
                        Response.Redirect("Admin.aspx");
                    }
                    
                }
            
        }
    }
}
