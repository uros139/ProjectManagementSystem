using Microsoft.AspNetCore.Mvc;
using ProjectManagementApplicationMVC.Models;
using ProjectManagementApplicationMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementApplicationMVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDBContext _db;

        public UsersController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var Users = (from u in _db.Users
                         select u
                         ).ToList();
            List<UserVM> users = new List<UserVM>();
            foreach (ApplicationUser au in Users)
            {
                var roles = _db.UserRoles.ToList();
                UserVM uservm = new UserVM();
                uservm.Name = au.Email;
                uservm.Id = au.Id;
                var roleid = (from ur in _db.UserRoles
                              where ur.UserId == au.Id
                              select ur.RoleId
                            ).FirstOrDefault();
                if (roleid != null) 
                {
                    var rolename = (from r in _db.Roles
                                    where r.Id == roleid
                                    select r.Name
                              ).First().ToString();
                    uservm.Role = rolename;
                }
           
                users.Add(uservm);

            }
            return View(users);
        }
        public IActionResult Delete(string? id)
        {
            if (id == null) {
                return NotFound();
            }
            var obj = _db.Users.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            UserVM uservm = new UserVM();
            uservm.Name = obj.Email;
            return View(uservm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(string? id) 
        {
            var user = _db.Users.Find(id);
            _db.Users.Remove(user);
            _db.SaveChanges();
           return  RedirectToAction("Index");
        }
    }
}
