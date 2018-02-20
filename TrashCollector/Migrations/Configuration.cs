namespace TrashCollector.Migrations
{
    using Data;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TrashCollector.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrashCollector.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Customers.AddOrUpdate(
                c => new { c.FirstName, c.LastName }, DummyData.getCustomers().ToArray());
            context.SaveChanges();

            context.Addresses.AddOrUpdate(
                p => new { p.Street }, DummyData.getAddresses(context).ToArray());

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!roleManager.RoleExists("Admin"))
            {
                roleManager.Create(new IdentityRole("Admin"));
            }

            if (!roleManager.RoleExists("User"))
            {
                roleManager.Create(new IdentityRole("User"));
            }

            if (!roleManager.RoleExists("TrashCollector"))
            {
                roleManager.Create(new IdentityRole("TrashCollector"));
            }


            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            if (userManager.FindByEmail("a@a.a") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "a@a.a",
                    UserName = "a@a.a",
                };
                var result = userManager.Create(user, "password");
                if (result.Succeeded)
                {
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Admin");
                }

            }
            if (userManager.FindByEmail("c@c.c") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "c@c.c",
                    UserName = "c@c.c"
                };
                var result = userManager.Create(user, "password");
                if (result.Succeeded)
                {
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "User");
                }

            }
            if (userManager.FindByEmail("t@t.t") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "t@t.t",
                    UserName = "t@t.t"
                };
                var result = userManager.Create(user, "password");
                if (result.Succeeded)
                {
                    userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "TrashCollector");
                }
            }

        }

    }
    }

