using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPLab.Admin
{
    public partial class AddIntroAirticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var dbm = new DBManager())
                {
                    if (dbm.NeedLogin())
                    {
                        Response.Redirect("Index.aspx?returnUrl=AddIntroArticle.aspx");
                    }
                }
            }
            TextEditor.FontNames += "宋体/宋体;黑体/黑体;仿宋/仿宋_GB2312;楷体/楷体_GB2312;隶书/隶书;幼圆/幼圆;微软雅黑/微软雅黑;";
            TextEditor.Toolbar = "RplTool";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            var articleId = Guid.NewGuid();
            var type = category.SelectedValue.Trim();
            using (var entity = new rpldbEntities())
            {
                var oldArticle = entity.Articles.FirstOrDefault(a => a.Type == type);
                if (oldArticle == null)
                {
                    oldArticle = new Article()
                    {
                        Id = articleId,
                        Title = title.Text.Trim(),
                        Content = TextEditor.Text,
                        Type = category.SelectedValue.Trim(),
                        Time = DateTime.Now,
                    };
                    entity.Articles.Add(oldArticle);
                }
                else
                {
                    oldArticle.Title = title.Text.Trim();
                    oldArticle.Content = TextEditor.Text;
                    oldArticle.Time = DateTime.Now;
                }
                try
                {
                    entity.SaveChanges();
                    Response.Redirect(Request.Url.ToString());
                }
                catch (Exception ex)
                {
                }
            }    
        }
    }
}