using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPLab.Admin
{
    /// <summary>
    /// Summary description for Manage1
    /// </summary>
    public class Manage1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string type = context.Request["type"];
            string ids = context.Request["ids"];
            ids = ids.TrimEnd('|');
            if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(ids))
            {
                context.Response.Write(false);
                return;
            }
            List<Guid> guids = ids.Split('|').Select(id => new Guid(id)).ToList();
            using (var entity = new rpldbEntities())
            {
                foreach (var guid in guids)
                {
                    if (type == "news" || type == "notice")
                    {
                        var article = entity.Articles.FirstOrDefault(a => a.Id == guid);
                        if (article != null)
                        {
                            entity.Articles.Remove(article);
                        }
                    }
                    else if (type == "link")
                    {
                        var link = entity.Links.FirstOrDefault(l => l.Id == guid);
                        if (link != null)
                        {
                            entity.Links.Remove(link);
                        }
                    }
                    else if (type == "newsImage")
                    {
                        var image = entity.NewsImages.FirstOrDefault(i => i.Id == guid);
                        if (image != null)
                        {
                            entity.NewsImages.Remove(image);
                        }
                    }
                    else if (type == "intro-article")
                    {
                        var article = entity.Articles.FirstOrDefault(a => a.Id == guid);
                        if (article != null)
                        {
                            entity.Articles.Remove(article);
                        }
                    }
                }
                try
                {
                    entity.SaveChanges();
                    context.Response.Write(true);
                }
                catch (Exception ex)
                {
                    context.Response.Write(false);
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