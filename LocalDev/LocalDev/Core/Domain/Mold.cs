using System;
using System.Collections.ObjectModel;

namespace LocalDev.Core.Domain
{
    public class Mold : Base
    {
        #region Fields
        public string Id { get; set; }
        public string MoldNo { get; set; }
        public string Note { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
