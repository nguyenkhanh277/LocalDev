using LocalDev.Core.Domain;
using LocalDev.Persistence;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LocalDev.Migrations
{
    using LocalDev.Core;
    using LocalDev.Core.Helper;
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
            string defaultPassword = "1511";
            string salt = SecurityHelper.CreateSalt(GlobalConstants.DEFAULT_SALT_LENGTH);
            string encryptedPassword = SecurityHelper.GenerateMD5(defaultPassword, salt);

            #region Add Users
            string userID1 = Guid.NewGuid().ToString();
            string userID2 = Guid.NewGuid().ToString();
            var users = new List<User>
            {
                new User
                {
                    Id = userID1,
                    Username = "admin",
                    Salt = salt,
                    Password = encryptedPassword,
                    FullName = "Administrator",
                    Gender = Core.GlobalConstants.GenderValue.Male,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new User
                {
                    Id = userID2,
                    Username = "khanh",
                    Salt = salt,
                    Password = encryptedPassword,
                    FullName = "Nguyễn Xuân Khánh",
                    Gender = Core.GlobalConstants.GenderValue.Male,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var user in users)
                projectDataContext.Users.AddOrUpdate(a => a.Id, user);
            #endregion


            #region Add AuthorityGroup
            int authorityGroup1 = 1;
            var authorityGroups = new List<AuthorityGroup>
            {
                new AuthorityGroup
                {
                    Id = authorityGroup1,
                    AuthorityGroupName = "Admin",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var authorityGroup in authorityGroups)
                projectDataContext.AuthorityGroups.Add(authorityGroup);
            #endregion


            #region Add ProgramFunctionMaster
            var programFunctionMasters = new List<ProgramFunctionMaster>
            {
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "User",
                    FunctionName = "Add",
                    Explanation = "Add user",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "User",
                    FunctionName = "Edit",
                    Explanation = "Edit user",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "User",
                    FunctionName = "Delete",
                    Explanation = "Delete user",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "User",
                    FunctionName = "Authority",
                    Explanation = "Authority user",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var programFunctionMaster in programFunctionMasters)
                projectDataContext.ProgramFunctionMasters.AddOrUpdate(a => a.Id, programFunctionMaster);
            #endregion


            #region Add ProgramFunctionAuthority
            var programFunctionAuthoritys = new List<ProgramFunctionAuthority>
            {
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "User",
                    FunctionName = "Add",
                    AuthorityGroup = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "User",
                    FunctionName = "Edit",
                    AuthorityGroup = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "User",
                    FunctionName = "Delete",
                    AuthorityGroup = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "User",
                    FunctionName = "Authority",
                    AuthorityGroup = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var programFunctionAuthority in programFunctionAuthoritys)
                projectDataContext.ProgramFunctionAuthoritys.AddOrUpdate(a => a.Id, programFunctionAuthority);
            #endregion


            #region Add UserAuthority
            var userAuthoritys = new List<UserAuthority>
            {
                new UserAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    UserID = userID1,
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var userAuthority in userAuthoritys)
                projectDataContext.UserAuthoritys.AddOrUpdate(a => a.Id, userAuthority);
            #endregion
        }

    }
}
