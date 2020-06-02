using System;
using System.Collections.ObjectModel;

namespace LocalDev.Core.Domain
{
    public class AuthorityGroup : Base
    {
        #region Fields
        public int? Id { get; set; }
        public string AuthorityGroupName { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
