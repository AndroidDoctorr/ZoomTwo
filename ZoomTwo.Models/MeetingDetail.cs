using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoomTwo.Data;

namespace ZoomTwo.Models
{
    public class MeetingDetail
    {
        public int MeetingId { get; set; }
        public MuteRule MuteRule { get; set; }
        public string Description { get; set; }
        public int OrganizationId { get; set; }
    }
}
