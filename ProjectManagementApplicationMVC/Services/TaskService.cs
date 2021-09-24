using Microsoft.AspNetCore.Identity;
using ProjectManagementApplicationMVC.Models;
using ProjectManagementApplicationMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProjectManagementApplicationMVC.Models.DomainModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjectManagementApplicationMVC.Services
{  
    public class TaskService : ITaskService
    {

        private readonly ApplicationDBContext _db;
        public TaskService(ApplicationDBContext db)
        {
            _db = db;
        }
    
        


        //Returning all Developers
        public List<DeveloperVM> getDeveloperList()
        {
            var developers = (from user in _db.Users join userRoles in _db.UserRoles
                              on user.Id equals userRoles.UserId join roles in 
                              _db.Roles.Where(x=>x.Name == Helper.Helper.Developer) on userRoles.RoleId
                              equals roles.Id
                              select new DeveloperVM
                              {
                                  Id = user.Id,
                                  Name = user.Name
                              }
                               ).ToList();
            return developers;
        }
        //Returning all Project Managers
        public List<ManagerVM> getManagerList()
        {
            var managers = (from user in _db.Users
                              join userRoles in _db.UserRoles
                              on user.Id equals userRoles.UserId
                              join roles in
                               _db.Roles.Where(x => x.Name == Helper.Helper.ProjectManager) on userRoles.RoleId
                                equals roles.Id
                              select new ManagerVM
                              {
                                  Id = user.Id,
                                  Name = user.Name
                              }
                            ).ToList();
            return managers;
        }


        public List<string> getStatusList()
        {
            List<string> listStatus = new List<string>();
            listStatus.Add("New");
            listStatus.Add("InProgress");
            listStatus.Add("Finished");
            return listStatus;

        }

        public List<Project> getProjectsList()
        {
            var projects = (from project in _db.Projects
                            select 
                            new Project { 
                            Id=project.Id,
                            Name=project.Name
                            }
                            ).ToList();
            return projects;
        }

        //Returning all users except admin
        public List<UserVM> getUsersList()
        {
            var users = (from user in _db.Users
                         join userRoles in _db.UserRoles
                         on user.Id equals userRoles.UserId
                         join roles in
                          _db.Roles.Where(x => x.Name != Helper.Helper.Admin) on userRoles.RoleId
                           equals roles.Id
                         select new UserVM
                         {
                             Id = user.Id,
                             Name = user.Name
                         }
                            ).ToList();
            return users;

        }
    }
}
