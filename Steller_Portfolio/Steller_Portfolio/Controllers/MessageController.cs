using Steller_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Steller_Portfolio.Controllers
{
    public class MessageController : Controller
    {
        StellerDBEntities db=new StellerDBEntities();
        public ActionResult Index()
        {   
            var values=db.TblMessage.Where(x=>x.isRead==null).ToList();
            return View(values);
        }
        public ActionResult MessageDetail(int id)
        {
            var message = db.TblMessage.Find(id);
            message.isRead = true;
            db.SaveChanges();
            return View(message);
        }
        public ActionResult ReadMessage() 
        {
            var values=db.TblMessage.Where(x=>x.isRead == true).ToList();
            return View(values);
        }
       
    }
}