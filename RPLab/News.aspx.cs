using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPLab
{
    public partial class News : System.Web.UI.Page
    {
        private string articleFormat = "<h2>{0}</h2><div class='news-info'>作者：{1}&nbsp;&nbsp;发布时间：{2}</div><hr />{3}";
        private string introArticleFormat = "<h2>{0}</h2><hr />{1}";
        protected void Page_Load(object sender, EventArgs e)
        {
            string idStr = Request["id"];
            if (!string.IsNullOrWhiteSpace(idStr))
            {
                Guid id = new Guid(idStr);
                using (rpldbEntities entity = new rpldbEntities())
                {
                    var article = entity.Articles.FirstOrDefault(a => a.Id == id);
                    if (article != null)
                    {
                        var time = article.DisplayTime ?? article.Time;
                        if (article.Type == "notice" || article.Type == "news")
                        {
                            ViewState["articleContent"] = string.Format(articleFormat, article.Title, article.Author, time, article.Content);
                        }
                        else
                        {
                            ViewState["articleContent"] = string.Format(introArticleFormat, article.Title, article.Content);
                        }
                    }
                }
            }
        }
    }
}