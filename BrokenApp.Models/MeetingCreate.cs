using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrokenApp.Data;

namespace BrokenApp.Models
{
    public class MeetingCreate
    {
        [Required]
        public MuteRule MuteRule { get; set; }
        [MaxLength(8000)]
        public string Description { get; set; }
        [Display(Name = "Organization")]
        public int OrganizationId { get; set; }
        // public SelectList organizationOptions { get; set; }
    }
}
