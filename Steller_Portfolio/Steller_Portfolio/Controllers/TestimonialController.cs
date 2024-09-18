using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Steller_Portfolio.Models;

namespace Steller_Portfolio.Controllers
{
    public class TestimonialController : Controller
    {
        StellerDBEntities db=new StellerDBEntities();
        public ActionResult Index()
        {
            var values=db.TblTestimonial.ToList();
            return View(values);
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(TblTestimonial Testimonial)
        {
            db.TblTestimonial.Add(Testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(TblTestimonial Testimonial)
        {
            var value = db.TblTestimonial.Find(Testimonial.TestimonialID);
            value.NameSurname = Testimonial.NameSurname;
            value.Title = Testimonial.Title;
            value.Description = Testimonial.Description;
            value.ImageUrl = Testimonial.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}