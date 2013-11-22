using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPLab
{
    public partial class More : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!IsPostBack)
            {
                string type = Request["type"];                
                if (!string.IsNullOrWhiteSpace(type))
                {
                    ViewState["type"] = type;
                    if (type == "notice")
                    {
                        ViewState["title"] = "通知公告";
                    }
                    else if (type == "news")
                    {
                        ViewState["title"] = "新闻";
                    }
                    string pageLength = ConfigurationManager.AppSettings.Get("PageLength");
                    int PAGE_LENGTH = int.Parse(pageLength);
                    using (var entity = new rpldbEntities())
                    {
                        var count = entity.Articles.Count(a=>a.Type == type) / PAGE_LENGTH + 1;
                        ViewState["totalPage"] = count;                        
                    }
                }
            }
        }
    }
}