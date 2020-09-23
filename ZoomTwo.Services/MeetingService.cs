using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoomTwo.Data;
using ZoomTwo.Models;

namespace ZoomTwo.Services
{
    public class MeetingService
    {
        private readonly Guid _userId;

        public MeetingService(Guid userId)
        {
            _userId = userId;
        }

        public MeetingDetail GetMeetingDetailsById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var meeting = ctx.Meetings.Single(m => m.Id == id);
                return new MeetingDetail
                {
                    MeetingId = meeting.Id,
                    MuteRule = meeting.MuteRule,
                    Description = meeting.Description,
                    OrganizationId = meeting.OrganizationId
                };
            }
        }

        public bool CreateMeeting(MeetingCreate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var newMeting = new Meeting()
                {
                    MuteRule = model.MuteRule,
                    Description = model.Description,
                    OrganizationId = model.OrganizationId
                };

                ctx.Meetings.Add(newMeting);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<MeetingListItem> GetMeetingList()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Meetings.Select(m => new MeetingListItem
                {
                    MeetingId = m.Id,
                    MuteRule = m.MuteRule,
                    Description = m.Description,
                    OrganizationName = m.Organization.Name
                });

                return query.ToList();
            }
        }

        public bool UpdateMeeting(MeetingEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var meeting = ctx.Meetings.Single(m => m.Id == model.MeetingId);
                meeting.Description = model.Description;
                meeting.MuteRule = model.MuteRule;
                meeting.OrganizationId = model.OrganizationId;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
