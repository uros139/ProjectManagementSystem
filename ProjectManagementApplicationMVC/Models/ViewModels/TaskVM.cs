using ProjectManagementApplicationMVC.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementApplicationMVC.Models.ViewModels
{
    
    public class TaskVM
    {
        
        public int? Id { get; set; }
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Must be at least 4 characters long.")]
        public string Name { get; set; }
        public status Status { get; set; }
        [Required]
        public string due { get; set; }
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Must be at least 5 characters long.")]
        public string Description { get; set; }
        [Range(0, 100,
      ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Progress { get; set; }
        public string DeveloperId { get; set; }
        public string ManagerId { get; set; }
        public bool IsDeveloperAssigned { get; set; }
        public string AdminId { get; set; }
        public string ManagerName { get; set; }
        public string DeveloperName { get; set; }
        public string AdminName { get; set; }
        public bool isForClient { get; set; }
        public string ProjectName { get; set; }
        public int ProjectId { get; set; }
    }
}
