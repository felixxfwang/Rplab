using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace RPLab
{
    /// <summary>
    /// Summary description for Pager
    /// </summary>
    public class Pager : IHttpHandler
    {
        private string moreFormat = "<li><a href='News.aspx?id={0}' target='_blank'>{1}</a><span>{2}</span><div style='clear:both' /></li>";
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
                    string moreHtml = string.Empty;
                    var articles = entity.Articles.Where(a => a.Type == type).OrderByDescending(a => a.Time).Skip(pageNumber * PAGE_LENGTH).Take(PAGE_LENGTH);
                    foreach (var article in articles)
                    {
                        var time = article.DisplayTime ?? article.Time;
                        moreHtml += string.Format(moreFormat, article.Id, article.Title, ((DateTime)time).ToString("yyyy/MM/dd"));
                    }
                    context.Response.ContentType = "text/html";
                    context.Response.Write(moreHtml);
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