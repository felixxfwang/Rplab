using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPLab
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var entity = new rpldbEntities())
                {
                    var lab = entity.Articles.FirstOrDefault(a => a.Type == "LabIntroPage");
                    var teacher = entity.Articles.FirstOrDefault(a => a.Type == "TeachersPage");
                    var student = entity.Articles.FirstOrDefault(a => a.Type == "StudentsPage");
                    var research = entity.Articles.FirstOrDefault(a => a.Type == "ResearchPage");
                    var studentWork = entity.Articles.FirstOrDefault(a => a.Type == "StudentWorkPage");
                    var exchange = entity.Articles.FirstOrDefault(a => a.Type == "ExchangePage");
                    ViewState["LabIntro"] = lab != null ? "News.aspx?id=" + lab.Id : ConfigurationManager.AppSettings.Get("LabIntroDefaultPage");
                    ViewState["Teachers"] = teacher != null ? "News.aspx?id=" + teacher.Id : ConfigurationManager.AppSettings.Get("TeachersDefaultPage");
                    ViewState["Students"] = student != null ? "News.aspx?id=" + student.Id : ConfigurationManager.AppSettings.Get("StudentsDefaultPage");
                    ViewState["Research"] = research != null ? "News.aspx?id=" + research.Id : ConfigurationManager.AppSettings.Get("ResearchDefaultPage");
                    ViewState["StudentWork"] = studentWork != null ? "News.aspx?id=" + studentWork.Id : ConfigurationManager.AppSettings.Get("StudentWorkDefaultPage");
                    ViewState["Exchange"] = exchange != null ? "News.aspx?id=" + exchange.Id : ConfigurationManager.AppSettings.Get("ExchangeDefaultPage");
                }
            }
        }
    }
}