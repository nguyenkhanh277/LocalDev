using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class MoldRepository : Repository<Mold>
    {
        public string id = "";

        public MoldRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Mold mold)
        {
            if (String.IsNullOrEmpty(mold.Id))
            {
                mold.Id = GetAutoID();
                mold.CreatedAt = DateTime.Now;
                mold.CreatedBy = GlobalConstants.username;
                Add(mold);
                id = mold.Id;
            }
            else
            {
                Update(mold);
            }
        }

        public void Update(Mold mold)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(mold.Id));
                if (raw != null)
                {
                    raw.CollectInformation(mold);
                    raw.EditedAt = DateTime.Now;
                    raw.EditedBy = GlobalConstants.username;
                    id = raw.Id;
                }
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public string GetAutoID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}