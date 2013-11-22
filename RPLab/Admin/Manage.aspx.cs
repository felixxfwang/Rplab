using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPLab.Admin
{
    public partial class Manage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var dbm = new DBManager())
                {
                    if (dbm.NeedLogin())
                    {
                        Response.Redirect("Index.aspx?returnUrl=Manage.aspx");
                    }
                }
                using (var entity = new rpldbEntities())
                {
                    var pageLength = ConfigurationManager.AppSettings.Get("PageLength");
                    var pageNumber = int.Parse(pageLength);
                    var noticeCount = entity.Articles.Count(a => a.Type == "notice") / pageNumber + 1;
                    var newsCount = entity.Articles.Count(a => a.Type == "news") / pageNumber + 1;
                    var linkCount = entity.Links.Count() / pageNumber + 1;
                    var newsPicCount = entity.NewsImages.Count() / pageNumber + 1;
                    var introCount = entity.Articles.Count(a => a.Type != "news" && a.Type != "notice") / pageNumber + 1;
                    ViewState["noticeTotalPage"] = noticeCount;
                    ViewState["newsTotalPage"] = noticeCount;
                    ViewState["linkTotalPage"] = noticeCount;
                    ViewState["newsPicTotalPage"] = noticeCount;
                    ViewState["introArticlePage"] = introCount;
                }
            }
        }
    }
}