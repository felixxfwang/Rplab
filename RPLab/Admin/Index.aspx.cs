using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPLab.Admin
{
    public partial class Index : System.Web.UI.Page
    {
        string returnUrl;
        DBManager dbm = new DBManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            string url = Request.QueryString["returnUrl"];
            returnUrl = url ?? "Manage.aspx";
            if (!IsPostBack)
            {                
                if (!dbm.NeedLogin())
                {
                    Response.Redirect(returnUrl);
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string strUserName = userName.Text.Trim();
            string strPassword = password.Text.Trim();
            if (dbm.Login(strUserName, strPassword))
            {
                Response.Redirect(returnUrl);
            }
            else
            {
                ViewState.Add("errorMsg", "密码错误");
            }
        }
    }
}