using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace RPLab
{
    public class DBManager :IDisposable
    {
        //数据库连接和断开相关
        private bool m_disposed;
        private readonly rpldbEntities entity;

        public DBManager()
        {
            this.entity = new rpldbEntities();
            this.m_disposed = false;
        }

        ~DBManager()
        {
            this.Dispose(false);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (this.m_disposed)
            {
                return;
            }
            if (this.entity != null)
            {
                //this.entity.Dispose();
            }
            this.m_disposed = true;
        }

        #region need login?
        public bool NeedLogin()
        {
            var sAccount = HttpContext.Current.Session["user"] as User ?? new User();
            if (sAccount.IsLogin)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region login
        public bool Login(string userName, string password)
        {
            try
            {
                var user = entity.Accounts.SingleOrDefault(a => a.UserName == userName && a.Password == password);
                if (user != null)
                {
                    HttpContext.Current.Session["user"] = new User
                    {
                        UserID = user.Id,
                        UserName = user.UserName,
                        IsLogin = true
                    };
                    return true;
                }
            }
            catch (Exception e)
            {
            }
            return false;
        }       
        #endregion

        #region upload
        public bool AddArticle(Article article)
        {
            try
            {
                entity.Articles.Add(article);
                entity.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }
        public bool AddPicture(NewsImage picture)
        {
            try
            {
                entity.NewsImages.Add(picture);
                entity.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
            }
            return false;
        }
        
        #endregion

        #region query
        public List<Article> QueryAticles(string type)
        {
            var articles = entity.Articles.Where(a => a.Type == type);
            return articles.Any() ? articles.ToList() : new List<Article>();
        }
        public Article QueryArticle(Guid id)
        {
            try
            {
                return entity.Articles.SingleOrDefault(a => a.Id == id);
            }
            catch
            {
            }
            return null;
        }        
        #endregion

        public bool ModifyPassword(string oldPassword, string newPassword)
        {
            var sAccount = HttpContext.Current.Session["user"] as User ?? new User();
            try
            {
                var user = entity.Accounts.SingleOrDefault(a => a.Id == sAccount.UserID && a.Password == oldPassword);
                if (user != null)
                {
                    user.Password = newPassword;
                    entity.SaveChanges();
                    return true;
                }
            }
            catch
            {
            }
            return false;
        }

        public bool AddLink(Link link)
        {
            try
            {
                entity.Links.Add(link);
                entity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }
    }
}
