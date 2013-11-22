using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace RPLab.Admin
{
    /// <summary>
    /// Summary description for Preview
    /// </summary>
    public class Preview : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/xml";
            context.Response.Write("<?xml version='1.0' encoding='utf-8'?>");
            if (context.Request.Files.Count > 0)
            {
                for (int i = 0; i < context.Request.Files.Count; i++)
                {
                    var file = context.Request.Files[i];
                    var fileExt = file.FileName.ToLower().Substring(file.FileName.LastIndexOf('.'));
                    if (fileExt == ".jpg" || fileExt == ".gif"
                        || fileExt == ".png" || fileExt == ".bmp")
                    {
                        string directory = context.Server.MapPath("~/Images/news");
                        Guid photoId = Guid.NewGuid();
                        string fileName = string.Format("{0}{1}", photoId, fileExt);
                        string path = Path.Combine(directory, fileName);
                        file.SaveAs(path);

                        context.Response.Write(string.Format("<root><type>success</type><content>{0}</content><photoId>{1}</photoId><photoExt>{2}</photoExt></root>",
                            "../Images/news/" + fileName, photoId, fileExt));
                    }
                    else
                    {
                        context.Response.Write(@"<root><type>fail</type><content>错误的图片格式</content></root>");
                    }
                }
            }
            else
            {
                context.Response.Write(@"<type>fail</type><content>请选择图片</content>");
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