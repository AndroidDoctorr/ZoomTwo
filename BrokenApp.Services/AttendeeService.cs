using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrokenApp.Data;
using BrokenApp.Models;

namespace BrokenApp.Services
{
    public class AttendeeService
    {
        public IEnumerable<AttendeeListItem> GetAttendeeList()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Attendees.Select(a => new AttendeeListItem
                {
                    ID = a.ID,
                    Name = a.Name
                });

                return query.ToList();
            }
        }

        public bool CreateAttendee(AttendeeCreate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var newAttendee = new Attendee()
                {
                    Name = model.Name
                };

                ctx.Attendees.Add(newAttendee);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
