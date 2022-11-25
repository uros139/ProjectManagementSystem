using Microsoft.AspNetCore.Mvc;
using ProjectManagementApplicationMVC.Models;
using ProjectManagementApplicationMVC.Models.DomainModels;
using ProjectManagementApplicationMVC.Models.ViewModels;
using ProjectManagementApplicationMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementApplicationMVC.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ITaskService _itaskService;
        private readonly ApplicationDBContext _db;
        public ProjectController(ApplicationDBContext db, ITaskService taskService)
        {
            _db = db;
            _itaskService = taskService;

        }


        public IActionResult Index()
        {
            IEnumerable<Project> objList = _db.Projects;

            return View(objList);
        }
        public IActionResult Create()
        {

            ViewBag.Managers = _itaskService.getManagerList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Project obj)
        {

            var managerId = Request.Form["managersId"];
            obj.ProjectManagerId = managerId;
            obj.Progress = 0;
            _db.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var obj = _db.Projects.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            ViewBag.Managers = _itaskService.getManagerList();

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Project obj)
        {
            var managerId = Request.Form["managersId"];



            obj.ProjectManagerId = managerId;
            _db.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var obj = _db.Projects.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Projects.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Projects.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
