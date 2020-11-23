using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pagination.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Required]
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }

        [Required]
        [DisplayName("Project Manager Name")]
        public string ProjectManagerName { get; set; }

        public string ProjectStatus { get; set; }
    }
}