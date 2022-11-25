using Microsoft.AspNetCore.Mvc;
using ProjectManagementApplicationMVC.Models;
using ProjectManagementApplicationMVC.Models.DomainModels;
using ProjectManagementApplicationMVC.Models.ViewModels;
using ProjectManagementApplicationMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using status = ProjectManagementApplicationMVC.Models.DomainModels.status;

namespace ProjectManagementApplicationMVC.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        ApplicationDBContext _db;

        public TaskController(ITaskService taskService, ApplicationDBContext db)
        {
            _db = db;
            _taskService = taskService;
        }

        //INDEX
        public IActionResult Index()
        {
            ViewBag.DeveloperList = _taskService.getDeveloperList();
            ViewBag.ManagersList = _taskService.getManagerList();

            List<TaskVM> tasksVM = new List<TaskVM>();
            IEnumerable<Taskk> objList = _db.Tasks;
            foreach (Taskk t in objList)
            {
                TaskVM taskvm = new TaskVM();
                taskvm.Name = t.Name;
                taskvm.Description = t.Description;
                taskvm.Id = t.Id;
                taskvm.Status = t.Status;
                taskvm.Progress = t.Progress;
                taskvm.ProjectId = t.ProjectId;
                taskvm.IsDeveloperAssigned = t.IsDeveloperAssigned;
                taskvm.due = t.due.ToString().Substring(0, t.due.ToString().Length - 10);

                var projectname = (from p in _db.Projects
                                   where p.Id == t.ProjectId
                                   select p.Name
                                   ).ToList();
                taskvm.ProjectName = projectname.First();
                var managername = (from m in _db.Users
                                   where m.Id == t.ManagerId
                                   select m.Name
                    ).ToList();
                var developername = (from d in _db.Users
                                     where d.Id == t.DeveloperId
                                     select d.Email
                    ).ToList();
                if (managername.Count != 0)
                {
                    taskvm.ManagerName = managername.First();
                }
                string developerId = t.DeveloperId;
                int developerTaks = (from task in _db.Tasks
                                     where developerId == task.DeveloperId
                                     select task.DeveloperId
                                     ).Count();
                if (developerTaks < 3)
                {
                    taskvm.DeveloperId = developerId;

                }
                if (developername.Count != 0)
                {
                    taskvm.DeveloperName = developername.First();
                }
                tasksVM.Add(taskvm);
            }

            return View(tasksVM);
        }
        //CREATE GET
        public IActionResult Create()
        {
            ViewBag.Status = _taskService.getStatusList();
            ViewBag.Managers = _taskService.getManagerList();
            ViewBag.Developers = _taskService.getDeveloperList();
            ViewBag.Projects = _taskService.getProjectsList();

            return View();
        }
        //CREATE POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaskVM obj)
        {


            Taskk task = new Taskk();
            task.Description = obj.Description;
            task.Name = obj.Name;
            string due = obj.due;
            task.due = DateTime.ParseExact(due, "dd.MM.yyyy", null);
            task.ManagerId = Request.Form["managersId"];
            string statusTask = Request.Form["status"];

            //validation for developers, not more than 3 tasks
            string developerId = Request.Form["developersId"];
            int developerTaks = (from t in _db.Tasks
                                 where developerId == t.DeveloperId
                                 select t.DeveloperId
                                 ).Count();

            if (obj.IsDeveloperAssigned)
            {
                if (developerTaks < 3)
                {
                    task.DeveloperId = developerId;
                    task.IsDeveloperAssigned = true;

                }
                else
                {
                    return Ok("Can not assign more than 3 tasks to one developer!");
                }
            }
            task.Status = status.New;
            task.Progress = 0;

            //add project to task
            string projectId = Request.Form["projectsId"];
            int projectID = int.Parse(projectId);
            var projects = (from proj in _db.Projects
                            where proj.Id == projectID
                            select proj
                               ).ToList();
            Project pro = projects.First();
            task.ProjectId = pro.Id;



            _db.Add(task);
            _db.SaveChanges();

            //update project progress
            updateProjectProgress(task);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


        //EDIT GET
        public IActionResult Edit(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            List<TaskVM> tasksVM = new List<TaskVM>();
            IEnumerable<Taskk> objList = _db.Tasks;
            Taskk t = _db.Tasks.Find(id);

            if (t == null)
            {
                return NotFound();
            }

            TaskVM taskvm = new TaskVM();
            taskvm.Name = t.Name;
            taskvm.Description = t.Description;
            taskvm.Id = t.Id;
            taskvm.Status = t.Status;
            taskvm.Progress = t.Progress;
            taskvm.ProjectId = t.ProjectId;
            var managername = (from m in _db.Users
                               where m.Id == t.ManagerId
                               select m.Name
                ).ToList();

            if (managername.Count != 0)
            {
                taskvm.ManagerName = managername.First();
            }
            ViewBag.Managers = _taskService.getManagerList();
            ViewBag.Developers = _taskService.getDeveloperList();
            ViewBag.Projects = _taskService.getProjectsList();

            return View(taskvm);

        }
        //EDIT POST

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TaskVM obj)
        {

            Taskk t = _db.Tasks.Find(obj.Id);

            var managerId = Request.Form["managersId"];
            string developerId = Request.Form["developersId"];

            //Developer evaluation
            int developerTaks = (from tasks in _db.Tasks
                                 where developerId == tasks.DeveloperId
                                 select tasks.DeveloperId
                                 ).Count();

            if (obj.IsDeveloperAssigned)
            {
                if (developerTaks < 3)
                {
                    t.DeveloperId = developerId;
                    t.IsDeveloperAssigned = true;

                }
                else
                {
                    return Ok("Can not assign more than 3 tasks to one developer!");
                }
            }

            //if Admin unasssigns developer 
            if (obj.IsDeveloperAssigned == false && obj.Name != null && obj.due != null)
            {
                t.DeveloperId = null;
                t.IsDeveloperAssigned = false;
                t.due = DateTime.ParseExact(obj.due, "dd.MM.yyyy", null);

            }
            //if Manager unasssigns developer 
            if (obj.IsDeveloperAssigned == false && obj.Name == null && obj.due != null)
            {
                t.DeveloperId = null;
                t.IsDeveloperAssigned = false;
                try
                {
                    t.due = DateTime.ParseExact(obj.due, "dd.MM.yyyy", null);
                }
                catch
                {
                    new Exception("Invalid date format");
                    return Ok("Invalid date format, go back and enter valid date format: DD.MM.YYYY");
                }

            }




            //In case developer is assigned, name and manager will return null,
            //so they stay unchanged.
            if (obj.Name != null)
            {
                t.Name = obj.Name;
                t.ManagerId = managerId;
                t.due = DateTime.ParseExact(obj.due, "dd.MM.yyyy", null);


            }
            t.Description = obj.Description;
            t.Progress = obj.Progress;
            if (t.Progress == 100)
            {
                t.Status = status.Finished;
            }
            if (t.Progress < 100 && t.Progress > 0)
            {
                t.Status = status.InProgress;

            }
            updateProjectProgress(t);
            _db.Update(t);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var obj = _db.Tasks.Find(id);
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
            var obj = _db.Tasks.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Tasks.Remove(obj);
            _db.SaveChanges();
            updateProjectProgress(obj);
            return RedirectToAction("Index");
        }
        public void updateProjectProgress(Taskk t)
        {
            int taskscount = (from tasks in _db.Tasks
                              where tasks.ProjectId == t.ProjectId
                              select tasks.Id
                             ).Count();
            int sum = 0;
            foreach (Taskk task in _db.Tasks)
            {
                if (task.ProjectId == t.ProjectId)
                {
                    sum += task.Progress;
                }
            }
            int progressProject = sum / taskscount;
            Project project = (from p in _db.Projects
                               where p.Id == t.ProjectId
                               select p
                         ).First();
            project.Progress = progressProject;
            _db.Update(project);
            _db.SaveChanges();
        }
    }
}
