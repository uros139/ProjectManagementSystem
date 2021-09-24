using ProjectManagementApplicationMVC.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementApplicationMVC.Models.ViewModels
{
    public class ProjectVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Taskk> Tasks { get; set; }
    }
}
