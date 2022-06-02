using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EventCloud.Authorization.Roles;
using EventCloud.Authorization.Users;
using EventCloud.MultiTenancy;
using EventCloud.Models.Users;
using EventCloud.Models.Locations;
using EventCloud.Models;
using System.Threading.Tasks;
using System;
using EventCloud.Models.Emails;

namespace EventCloud.EntityFrameworkCore
{
    public class EventCloudDbContext : AbpZeroDbContext<Tenant, Authorization.Roles.Role, User, EventCloudDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<UserRegistration> UserRegistrations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Signup> Signup { get; set; }
        public EventCloudDbContext(DbContextOptions<EventCloudDbContext> options)
            : base(options)
        {
        }

        public Task<object> FindAsync(int accountId)
        {
            throw new NotImplementedException();
        }
    }
}
