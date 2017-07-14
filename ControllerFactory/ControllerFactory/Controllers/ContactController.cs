using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllerFactory.Controllers
{
    public class ContactController : IController
    {

        public ContactController(ILoggingService logging)
        {

        }

        public void Execute(RequestContext requestContext)
        {
            HttpContext.Current.Response.Write("Hi");
        }
    }
}
