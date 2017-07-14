using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;

namespace HealthAssist.MVC.Configuration
{
    public class RedirectModule : IHttpModule
    {

        private HttpApplication _context;

        public void Dispose()
        {

        }

        public void Init(HttpApplication context)
        {
            _context = context;
            _context.MapRequestHandler += RedirectUrls;
        }

        public void RedirectUrls(object src, EventArgs args)
        {
            RedirectSection section = WebConfigurationManager.GetWebApplicationSection("redirects") as RedirectSection;

            foreach (Redirect redirect in section.Redirects)
            {
                if (redirect.Old == _context.Request.RequestContext.HttpContext.Request.RawUrl)
                {
                    _context.Response.Redirect(redirect.New);
                }
            }
        }
    }
}
