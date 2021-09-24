using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectManagementApplicationMVC.Models;
using ProjectManagementApplicationMVC.Models.DomainModels;
using ProjectManagementApplicationMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementApplicationMVC.Services
{
    public interface ITaskService
    {
     
        public List<ManagerVM> getManagerList();
        public List<DeveloperVM> getDeveloperList();
        public List<Project> getProjectsList();
        public List<String> getStatusList();
        //public static List<SelectListItem> getPManagersForDropdown();
        public List<UserVM> getUsersList();
    }
}
