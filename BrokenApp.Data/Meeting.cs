using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenApp.Data
{
    public enum MuteRule { MuteAll, MuteNone, HonorSystem }
    // MuteAll = Mute all but host on entry, don't allow control
    // MuteNone = Don't mute anyone
    // HonorSystem = Mute all, but allow them to unmute themselves
    public class Meeting
    {
        public int Id { get; set; }
        public MuteRule MuteRule { get; set; }
        public string Description { get; set; }
        public int OrganizationId { get; set; }
        [ForeignKey("OrganizationId")]
        public virtual Organization Organization { get; set; }
        public virtual ICollection<Attendee> Attendees { get; set; }
    }
}
