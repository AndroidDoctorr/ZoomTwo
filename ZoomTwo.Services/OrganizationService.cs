using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoomTwo.Data;
using ZoomTwo.Models;

namespace ZoomTwo.Services
{
    public class OrganizationService
    {
        public bool CreateOrganization(OrganizationCreate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var newOrganization = new Organization()
                {
                    Name = model.Name
                };

                ctx.Organizations.Add(newOrganization);
                return ctx.SaveChanges() == 1;
            }
        }
        public OrganizationDetail GetOrganizationDetailsById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var organization = ctx.Organizations.Single(o => o.Id == id);
                return new OrganizationDetail
                {
                    OrganizationId = organization.Id,
                    Name = organization.Name
                };
            }
        }
        public IEnumerable<OrganizationListItem> GetOrganizationList()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Organizations.Select(o => new OrganizationListItem
                {
                    OrganizationId = o.Id,
                    Name = o.Name
                });

                return query.ToArray();
            }
        }

        public IEnumerable<Organization> GetOrganizations()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Organizations.ToList();
            }
        }

        public bool UpdateOrganization(OrganizationEdit model)
        {



            
            
            
            Thingy thingy = new Thingy();


            Thingy thingy2 = new Thingy("lalala");

            Thingy thingy3 = new Thingy(3);

            Thingy thingy4 = new Thingy("lalala", 5);


















            using (var ctx = new ApplicationDbContext())
            {
                var organization = ctx.Organizations.Single(m => m.Id == model.OrganizationId);
                organization.Name = model.Name;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
