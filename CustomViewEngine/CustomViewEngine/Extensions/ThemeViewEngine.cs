using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CustomViewEngine.Extensions
{
    public class ThemeViewEngine : RazorViewEngine
    {
        public ThemeViewEngine()
        {
            ViewLocationFormats = new string[] { "~/Theme/{1}/{0}.cshtml" };
            PartialViewLocationFormats = new string[] { "~/Theme/{1}/{0}.cshtml" };
        }
    }
}
