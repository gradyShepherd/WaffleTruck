using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WaffleTruck
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie menucookie = Request.Cookies["MenuItems"];
            // Check to see if a cookie was found with this name.

            if (menucookie != null)
            {
                
                string newString = menucookie["Order"].Replace("%0a", "<br />");
                orderDiv.InnerHtml += newString;
            }
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            HttpCookie menucookie = Request.Cookies["MenuItems"];
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string item = menucookie["Order"];
            string[] orders = menucookie["Order"].Replace("%0a",",").Split(',');
            DataInsert insert = new DataInsert();
            insert.InsertOrder(name, phone);
            for (int i= 0; i < orders.Length; i++)
            {
                if (!orders[i].Equals("", StringComparison.Ordinal))
                {
                    int rows = insert.InsertOrder(name, phone, orders[i]);
                    if (rows > 0)
                    {
                        Response.Write("It Worked!!");
                    }
                }
            }
            
            HttpCookie infocookie = new HttpCookie("Info");
            infocookie["Name"] = txtName.Text;
            infocookie["Phone"] = txtPhone.Text;
            Response.Cookies.Add(infocookie);

            Response.Redirect("Thanks.aspx");
        }
    }
}