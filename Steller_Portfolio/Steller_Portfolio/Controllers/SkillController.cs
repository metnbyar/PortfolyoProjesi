using Steller_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Steller_Portfolio.Controllers
{
    public class SkillController : Controller
    {
       StellerDBEntities db=new StellerDBEntities();
        public ActionResult Index()
        {
            var values=db.TblSkill.ToList();
            return View(values);
        }
        public ActionResult DeleteSkill(int id)
        {
            var valuess = db.TblSkill.Find(id);
            db.TblSkill.Remove(valuess);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(TblSkill skill)
        {
           
            db.TblSkill.Add(skill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = db.TblSkill.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(TblSkill skill)
        {
            var value = db.TblSkill.Find(skill.SkillId);
            value.SkillName = skill.SkillName;
            value.Title = skill.Title;
            value.Description = skill.Description;
            value.Value= skill.Value;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}