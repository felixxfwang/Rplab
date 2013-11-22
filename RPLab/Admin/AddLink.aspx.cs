using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPLab.Admin
{
    public partial class AddLink : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var dbm = new DBManager())
                {
                    if (dbm.NeedLogin())
                    {
                        Response.Redirect("Index.aspx?returnUrl=AddLink.aspx");
                    }
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = linkName.Text.Trim();
            string address = linkAddress.Text.Trim();
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address)) return;
            using (var dbm = new DBManager())
            {
                var link = new Link
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    Address = address
                };
                if (dbm.AddLink(link))
                {
                    Response.Redirect(Request.Url.ToString()); 
                }
            }
        }
    }
}