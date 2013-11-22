using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

namespace RPLab
{
    public partial class UpImg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string imgdir = UploadImage();
            string script = "window.parent.upimg('" + imgdir + "');";
            ResponseScript(script);
        }

        private string UploadImage()
        {            
            if (Uploader.HasFile)
            {
                string name = Uploader.FileName;
                string ext = name.Substring(name.LastIndexOf('.'));
                string saveName = Guid.NewGuid() + ext;
                string path = Server.MapPath("~/Images/upload/");
                string savePath = path + saveName;
                string displayName = "/Images/upload/" + saveName;
                Uploader.SaveAs(savePath);
                return displayName;
            }
            return string.Empty;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string script = "window.parent.close();";
            ResponseScript(script);
        }
        /// <summary>
        /// 输出脚本
        /// </summary>
        public void ResponseScript(string script)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder("<script language='javascript' type='text/javascript'>");
            sb.Append(script);
            sb.Append("</script>");
            ClientScript.RegisterStartupScript(this.GetType(), RandomString(1), sb.ToString());
        }
        /// <summary>
        /// 获得随机数
        /// </summary>
        /// <param name="count">长度</param>
        /// <returns></returns>
        public static string RandomString(int count)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] data = new byte[count];
            rng.GetBytes(data);
            return BitConverter.ToString(data).Replace("-", "");
        }
    }
}