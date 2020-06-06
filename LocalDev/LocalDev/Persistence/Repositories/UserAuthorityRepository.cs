using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class UserAuthorityRepository : Repository<UserAuthority>
    {
        public UserAuthorityRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(UserAuthority userAuthority)
        {
            if (String.IsNullOrEmpty(userAuthority.Id))
            {
                userAuthority.Id = GetAutoID();
                userAuthority.CreatedAt = DateTime.Now;
                userAuthority.CreatedBy = GlobalConstants.username;
                Add(userAuthority);
            }
            else
            {
                Update(userAuthority);
            }
        }

        public void Update(UserAuthority userAuthority)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(x => x.Id.Equals(userAuthority.Id));
                if (raw != null)
                {
                    raw.CollectInformation(userAuthority);
                    raw.EditedAt = DateTime.Now;
                    raw.EditedBy = GlobalConstants.username;
                }
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void DeleteByUserID(string userID)
        {
            Remove(FirstOrDefault(x => x.UserID.Equals(userID)));
        }

        public string GetAutoID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}