using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementApplicationMVC.Models.DomainModels
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Must be at least 4 characters long.")]
        public string Name { get; set; }
        [Range(10, 100,
      ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Progress { get; set; }
        [ForeignKey("Users")]
        public string ProjectManagerId { get; set; }
        public ICollection<Taskk> Tasks { get; set; }

        public static implicit operator Project(StringValues v)
        {
            throw new NotImplementedException();
        }
    }
}
