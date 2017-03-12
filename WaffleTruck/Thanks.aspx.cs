using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WaffleTruck
{
    public partial class Thanks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           HttpCookie foodcookie = Request.Cookies["MenuItems"];
            string newString = foodcookie["Order"].Replace("%0a", "\n");
            txtReview.Text = newString;

           HttpCookie namecookie = Request.Cookies["Info"];

            lblName.Text = "Name: " + namecookie["Name"];
            lblPhone.Text = "Phone #: " + namecookie["Phone"];
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}