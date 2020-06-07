using System;
using System.Collections.ObjectModel;

namespace LocalDev.Core.Domain
{
    public class Shift : Base
    {
        #region Fields
        public string Id { get; set; }
        public string ShiftNo { get; set; }
        public string Note { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
