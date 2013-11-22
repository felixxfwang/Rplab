using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPLab.Admin
{
    public partial class AddArticle : System.Web.UI.Page
    {
        private string type = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            type = Request["type"];
            if (!IsPostBack)
            {
                using (var dbm = new DBManager())
                {
                    if (dbm.NeedLogin())
                    {
                        Response.Redirect("Index.aspx?returnUrl=AddArticle.aspx?type=" + type);
                    }
                }
            }
            TextEditor.FontNames += "宋体/宋体;黑体/黑体;仿宋/仿宋_GB2312;楷体/楷体_GB2312;隶书/隶书;幼圆/幼圆;微软雅黑/微软雅黑;";
            TextEditor.Toolbar = "RplTool";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            var articleId = Guid.NewGuid();
            type = Request["type"];
            DateTime displayTime;
            IFormatProvider ifp = new CultureInfo("zh-CN", true);
            bool timeParseSuccess = DateTime.TryParseExact(DateTimePicker.Text.Trim(), new string[] { "yyyy/MM/dd", "yyyy-MM-dd", "yyyyMMdd" }, ifp, DateTimeStyles.None, out displayTime);
            var article = new Article()
            {
                Id = articleId,
                Title = title.Text.Trim(),
                Author = author.Text.Trim(),
                Content = TextEditor.Text,
                Type = type,
                Time = DateTime.Now,
            };
            if (timeParseSuccess)
            {
                article.DisplayTime = displayTime;
            }

            using (var dbm = new DBManager())
            {
                if (dbm.AddArticle(article))
                {
                    Response.Redirect(Request.Url.ToString());
                }
            }
        }
    }
}