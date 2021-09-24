using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementApplicationMVC.Helper
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Developer = "Developer";
        public static string ProjectManager = "ProjectManager";
        public static string New = "New";
        public static string InProgress = "InProgress";
        public static string Finished = "Finished";

        public static List<SelectListItem> GetRolesForDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value=Helper.Admin,Text=Helper.Admin },
                new SelectListItem{Value=Helper.Developer,Text=Helper.Developer},
                new SelectListItem{Value=Helper.ProjectManager,Text=Helper.ProjectManager }

            };
        }
        public static List<SelectListItem> GetTaskStatusForDropdown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value=Helper.New,Text=Helper.New },
                new SelectListItem{Value=Helper.InProgress,Text=Helper.InProgress},
                new SelectListItem{Value=Helper.Finished,Text=Helper.Finished }

            };
        }

    }
}
