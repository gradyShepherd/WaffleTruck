using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using System.Web.Providers.Entities;

namespace WaffleTruck
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;
        protected int userId;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;
            DataInsert insert = new DataInsert();

            userId = insert.LoginUser(user, pass);
            HttpCookie userCookie = Request.Cookies["UserId"];
            userCookie.Value = userId.ToString();
            /*
            if (userId == 0)
                OrderHistoryLink.Visible = false;
            else
                OrderHistoryLink.Visible = true;
                */
            Page_Load(sender, e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WebUserControl1.Visible = false;
                OrderHistoryLink.Visible = false;
            }

            string user = username.Text;
            string pass = password.Text;
            DataInsert insert = new DataInsert();
            //userId = insert.LoginUser(user, pass);
            //string userNum = user["userId"];
            HttpCookie userCookie = Context.Request.Cookies["UserId"];
            if (userCookie == null)//.Equals("", StringComparison.Ordinal))
            {
                userCookie = Response.Cookies["UserId"];
                userCookie.Value = userId.ToString();
                Response.Cookies.Add(userCookie);
            }
            else
            {
                //userCookie = Response.Cookies["UserId"];
                if (userId != 0)
                {
                    userCookie.Value = userId.ToString();
                }
                string userNum = userCookie.Value;
                //Response.Write(userNum);
                if (userNum == "0")
                {
                    OrderHistoryLink.Visible = false;
                }
                else
                {
                    OrderHistoryLink.Visible = true;
                }
            }
        }

        protected void btnShowMenu_Click(object sender, EventArgs e)
        {
            if (!WebUserControl1.Visible)
            {
                WebUserControl1.Visible = true;
            }
            else
            {
                WebUserControl1.Visible = false;

            }
        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }
    }

}