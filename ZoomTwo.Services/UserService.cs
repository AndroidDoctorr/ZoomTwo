using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoomTwo.Data;

namespace ZoomTwo.Services
{
    public class UserService
    {
        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Users.ToList();
            }
        }

        public IEnumerable<IdentityRole> GetAllRoles()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Roles.ToList();
            }
        }
    }
}
