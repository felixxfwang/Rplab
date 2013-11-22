using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace RPLab.Admin
{
    /// <summary>
    /// Summary description for AdminPager
    /// </summary>
    public class AdminPager : IHttpHandler
    {
        private string articleListFormat = "<li><input type='checkbox' name='checkbox' value='{3}' /><a href='../News.aspx?id={0}' target='_blank'>{1}</a><span>{2}</span></li>";
        private string linksFormat = "<li><input type='checkbox' name='checkbox' value='{2}' /><a href='{0}' target='_blank'>{1}</a></li>";
        private string imageFormat = "<div class='manage-image-box'><img title='{2}' src='../Images/news/{0}{1}'/><input type='checkbox' name='checkbox' value='{3}' /></div>";
        public void ProcessRequest(HttpContext context)
        {
            string type = context.Request["type"];
            string page = context.Request["page"];
            string pageLength = ConfigurationManager.AppSettings.Get("PageLength");
            int PAGE_LENGTH = int.Parse(pageLength);

            if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(page)) return;
            int pageNumber;
            if (int.TryParse(page, out pageNumber))
            {
                using (var entity = new rpldbEntities())
                {
                    string listHtml = "<ul>";
                    if (type == "notice" || type == "news")
                    {
                        var articles = entity.Articles.Where(a => a.Type == type).OrderByDescending(a => a.Time).Skip(pageNumber * PAGE_LENGTH).Take(PAGE_LENGTH);
                        foreach (var article in articles)
                        {
                            var time = article.DisplayTime ?? article.Time;
                            listHtml += string.Format(articleListFormat, article.Id, article.Title, ((DateTime)time).ToString("yyyy/MM/dd"), article.Id);
                        }
                    }
                    else if (type == "link")
                    {
                        var links = entity.Links.OrderByDescending(l => l.Name).Skip(pageNumber * PAGE_LENGTH).Take(PAGE_LENGTH);
                        foreach (var link in links)
                        {
                            listHtml += string.Format(linksFormat, link.Address, link.Name, link.Id);
                        }
                    }
                    else if (type == "newsImage")
                    {
                        var images = entity.NewsImages.OrderByDescending(i => i.Time).Skip(pageNumber * PAGE_LENGTH).Take(PAGE_LENGTH);
                        foreach (var image in images)
                        {
                            listHtml += string.Format(imageFormat, image.Id, image.Ext, image.Description, image.Id);
                        }
                        listHtml += "<div style='clear:both'></div>";
                    }
                    else if (type == "intro-article")
                    {
                        var articles = entity.Articles.Where(a => a.Type != "news" && a.Type != "notice").OrderByDescending(a => a.Time).Skip(pageNumber * PAGE_LENGTH).Take(PAGE_LENGTH);
                        foreach (var article in articles)
                        {
                            var time = article.DisplayTime ?? article.Time;
                            listHtml += string.Format(articleListFormat, article.Id, article.Title, ((DateTime)time).ToString("yyyy/MM/dd"), article.Id);
                        }
                    } 
                    listHtml += "</ul>";
                    context.Response.ContentType = "text/html";
                    context.Response.Write(listHtml);
                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}