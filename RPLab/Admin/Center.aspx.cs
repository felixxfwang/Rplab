using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPLab.Admin
{
    public partial class Center : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var dbm = new DBManager())
            {
                if (dbm.NeedLogin())
                {
                    Response.Redirect("Index.aspx?returnUrl=Center.aspx");
                }
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            using (var dbm = new DBManager())
            {
                var oldPassword =Request["oldPassword"];
                var newPassword = Request["newPassword"];
                if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword))
                {
                    return;
                }
                dbm.ModifyPassword(oldPassword, newPassword);
            }
        }
    }
}