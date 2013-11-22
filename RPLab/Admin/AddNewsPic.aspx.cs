using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPLab.Admin
{
    public partial class AddNewsPic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var dbm = new DBManager())
                {
                    if (dbm.NeedLogin())
                    {
                        Response.Redirect("Index.aspx?returnUrl=AddNewsPic.aspx");
                    }
                }
            }
        }
        protected void display_Click(object sender, EventArgs e)
        {
            var photoId = Request["photoId"];
            var photoExt = Request["photoExt"];
            if (!string.IsNullOrEmpty(photoId) || string.IsNullOrEmpty(photoExt))
            {
                var cUser = Session["user"] as User ?? new User();
                var picId = new Guid(photoId);
                var pLink = link.Text.Trim();
                var pDescription = description.Text.Trim();
                var picture = new NewsImage
                {
                    Id = picId,
                    Description = pDescription,
                    Time = DateTime.Now,
                    ArticleLink = pLink,
                    Ext = photoExt
                };
                using (var dbm = new DBManager())
                {
                    if (dbm.AddPicture(picture))
                    {
                        Response.Redirect("AddNewsPic.aspx");
                    }
                }
            }
        }
    }
}