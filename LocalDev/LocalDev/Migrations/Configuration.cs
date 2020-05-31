using LocalDev.Core.Domain;
using LocalDev.Persistence;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LocalDev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<LocalDev.Persistence.ProjectDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjectDataContext projectDataContext)
        {
            #region Add Users
            var users = new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid().ToString(),
                    Username = "admin",
                    Password = "admin",
                    FullName = "Administrator",
                    Gender = Core.GlobalConstants.GenderValue.Male,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new User
                {
                    Id = Guid.NewGuid().ToString(),
                    Username = "test",
                    Password = "test",
                    FullName = "test",
                    Gender = Core.GlobalConstants.GenderValue.Male,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var user in users)
                projectDataContext.Users.AddOrUpdate(a => a.Id, user);
            #endregion
        }

    }
}
