﻿using Steller_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Steller_Portfolio.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        StellerDBEntities db=new StellerDBEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult DefaultFeaturePartial() 
        {
            ViewBag.project = db.TblProject.Count();
            ViewBag.testimonial=db.TblTestimonial.Count();
            ViewBag.skill=db.TblSkill.Count();
           var values = db.TblFeature.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultAboutPartial() 
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult SendMessage() 
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult SendMessage(TblMessage message)
        {
            
            db.TblMessage.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public PartialViewResult DefaultServicePartial() 
        {
            var values=db.TblService.Where(x=>x.ServiceStatus==true).ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultSkillPartial()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultProjectPartial()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultTestimonialPartial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultContactInfoPartial()
        {
            var values = db.TblContact.ToList();
            return PartialView(values);
        }
        public PartialViewResult UILayoutFooterPartial()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }
    }
}