using Steller_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Steller_Portfolio.Controllers
{
    [AllowAnonymous]
    public class UILayoutController : Controller
    {
        StellerDBEntities db=new StellerDBEntities();
        
        public ActionResult Index()
        {
            return View();
        }
        
    }
}