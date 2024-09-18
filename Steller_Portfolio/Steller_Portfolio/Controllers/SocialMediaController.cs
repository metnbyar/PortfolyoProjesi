using Steller_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Steller_Portfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        StellerDBEntities db=new StellerDBEntities();
        public ActionResult Index()
        {
            var values = db.TblSocialMedia.ToList();
            return View(values);
        }
        public ActionResult DeleteSocialMedia(int id)
        {
            var valuess = db.TblSocialMedia.Find(id);
            db.TblSocialMedia.Remove(valuess);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSocialMedia(TblSocialMedia socialMedia)
        {

            db.TblSocialMedia.Add(socialMedia);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = db.TblSocialMedia.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(TblSocialMedia socialMedia)
        {
            var value = db.TblSocialMedia.Find(socialMedia.SocialMediaId);
            value.SocialMediaName = socialMedia.SocialMediaName;
            value.Url = socialMedia.Url;
            value.Icon = socialMedia.Icon;
            
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}