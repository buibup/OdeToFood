using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {
        
        public ActionResult Search(string name = "BUI")
        {
            throw new Exception("Something terrible has happended");

            var message = Server.HtmlEncode(name);

            return Content(message);
        }
        
    }
}