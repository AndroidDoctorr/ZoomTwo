using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrokenApp.Data;

namespace BrokenApp.Models
{
    public class MeetingListItem
    {
        public int MeetingId { get; set; }
        [Display(Name = "Mute Rule")]
        public MuteRule MuteRule { get; set; }
        public string Description { get; set; }
        [Display(Name = "Organization")]
        public string OrganizationName { get; set; }
    }
}
