using Steller_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Steller_Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        StellerDBEntities db=new StellerDBEntities();
        public ActionResult Index()
        {
            var values=db.TblProject.ToList();
            return View(values);
        }
        public ActionResult DeleteProject(int id) 
        {
            var value=db.TblProject.Find(id);
            db.TblProject.Remove(value);
            db.SaveChanges();
            return RedirectToAction ("Index");
        }
        [HttpGet]
        public ActionResult AddProject() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProject(TblProject project)
        {
            db.TblProject.Add(project);
            db.SaveChanges ();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id) 
        {
            var value=db.TblProject.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProject(TblProject project)
        {
            var value = db.TblProject.Find(project.ProjectId);
            value.ImageUrl = project.ImageUrl;
            value.Title= project.Title;
            value.Description= project.Description; 
            value.GitHubUrl= project.GitHubUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }       
    }
}