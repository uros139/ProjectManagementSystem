using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementApplicationMVC.Models.DomainModels
{
    public enum status { New, InProgress, Finished };
    public class Taskk
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Must be at least 4 characters long.")]
        public string Name { get; set; }
        public status Status { get; set; }
        [Required]
        public DateTime due { get; set; }
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Must be at least 5 characters long.")]
        public string Description { get; set; }

        public int Progress { get; set; }
        public string DeveloperId { get; set; }
        public string ManagerId { get; set; }
        public bool IsDeveloperAssigned { get; set; }
        public string AdminId { get; set; }
        public int ProjectId { get; set; }
    }
}
