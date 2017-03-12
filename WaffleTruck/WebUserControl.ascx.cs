using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WaffleTruck
{
    public partial class WebUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string myFood;
        public List<string> orders = new List<string>();

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            // Create the cookie object.
            orders.Clear();
            HttpCookie itemcookie = new HttpCookie("MenuItems");
            foreach (ListItem item in lstFood.Items)
                if (item.Selected)
                {
                    orders.Add(item.ToString()); //FIX ME0-------------------------------------------
                                                 //lblFood.Text = item.ToString();
                    myFood += item.ToString() + "\n";
                }
            // Set a value in it.
            itemcookie["order"] = myFood;
            // Add it to the current web response.
            Response.Cookies.Add(itemcookie);

            //Response.Redirect("Checkout.aspx");
        }
    }
}