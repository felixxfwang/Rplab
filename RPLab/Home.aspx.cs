using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPLab
{
    public partial class Home : System.Web.UI.Page
    {
        protected string noticeHtml = string.Empty;
        protected string newsHtml = string.Empty;
        protected string linkHtml = string.Empty;
        protected string newsImageHtml = string.Empty;
        protected string newsImagePreHtml = string.Empty;

        private string articleLinkFormat = string.Empty;
        private string linkFormat = string.Empty;
        private string newsFocusImagePreFormat = string.Empty;
        private string newsNormalImagePreFormat = string.Empty;
        private string newsImageFormat = string.Empty;

        private const int MAX_ARTICLE_COUNT = 8;
        private const int MAX_NEWS_IMAGE_COUNT = 5;

        private int noticeTitleMaxLength;
        private int newsTitleMaxLength;
        private int linkTitleMaxLength;
        private int newsImageMaxLength;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                articleLinkFormat = "<li><a href='News.aspx?Id={0}' title='{3}' target='_blank'>{1}</a><span>{2}</span></li>";
                linkFormat = "<li><a href='{0}' title='{2}' target='_blank'>{1}</a></li>";
                newsFocusImagePreFormat = "<li class='focus'><img src='Images/news/{0}{1}' alt='{2}' /> </li>";
                newsNormalImagePreFormat = "<li><img src='Images/news/{0}{1}' alt='{2}' /> </li>";
                newsImageFormat = "<a href='{0}' title='{4}' target='_blank'><img alt='{1}' src='Images/news/{2}{3}' /></a>";
                noticeTitleMaxLength = int.Parse(ConfigurationManager.AppSettings.Get("NoticeTitleMaxLength"));
                newsTitleMaxLength = int.Parse(ConfigurationManager.AppSettings.Get("NewsTitleMaxLength"));
                linkTitleMaxLength = int.Parse(ConfigurationManager.AppSettings.Get("LinkTitleMaxLength"));
                newsImageMaxLength = int.Parse(ConfigurationManager.AppSettings.Get("NewsImageMaxLength"));
                FillArticle();
                FillLink();
                FillNewsImage();
            }
        }


        private void FillArticle()
        {
            using (var entity = new rpldbEntities())
            {
                var articles = entity.Articles;
                var news = articles.Where(a => a.Type == "news").OrderByDescending(a => a.Time).Take(MAX_ARTICLE_COUNT);
                var notices = articles.Where(a => a.Type == "notice").OrderByDescending(a => a.Time).Take(MAX_ARTICLE_COUNT);

                foreach (var n in news)
                {
                    var title = n.Title.Length > newsTitleMaxLength ? n.Title.Substring(0, newsTitleMaxLength) + "..." : n.Title;
                    var time = n.DisplayTime ?? n.Time;
                    newsHtml += string.Format(articleLinkFormat, n.Id, title, ((DateTime)time).ToShortDateString(),n.Title);
                }
                foreach (var n in notices)
                {
                    var title = n.Title.Length > noticeTitleMaxLength ? n.Title.Substring(0, noticeTitleMaxLength) + "..." : n.Title;
                    var time = n.DisplayTime ?? n.Time;
                    noticeHtml += string.Format(articleLinkFormat, n.Id, title, ((DateTime)time).ToShortDateString(),n.Title);
                }
            }
        }
        private void FillLink()
        {
            using (var entity = new rpldbEntities())
            {
                var links = entity.Links;
                foreach (var link in links)
                {
                    var name = link.Name.Length > linkTitleMaxLength ? link.Name.Substring(0, linkTitleMaxLength) + "..." : link.Name;
                    linkHtml += string.Format(linkFormat, link.Address, name, link.Name);
                }
            }
        }
        private void FillNewsImage()
        {
            using (var entity = new rpldbEntities())
            {
                var images = entity.NewsImages.OrderByDescending(i => i.Time).Take(MAX_NEWS_IMAGE_COUNT);
                int count = 1;
                foreach (var image in images)
                {
                    if (count == 1)
                    {
                        newsImagePreHtml += string.Format(newsFocusImagePreFormat, image.Id, image.Ext, count++);
                    }else{
                        newsImagePreHtml += string.Format(newsNormalImagePreFormat, image.Id, image.Ext, count++);
                    }
                    var description = image.Description.Length > newsImageMaxLength ? image.Description.Substring(0, newsImageMaxLength) + "..." : image.Description;
                    newsImageHtml += string.Format(newsImageFormat, image.ArticleLink, description, image.Id, image.Ext,image.Description);
                }
            }
        }
    }
}