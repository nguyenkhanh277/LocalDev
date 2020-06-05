using System;
using System.Collections.ObjectModel;

namespace LocalDev.Core.Domain
{
    public class Barcode : Base
    {
        #region Fields
        public string Id { get; set; }
        public string PartNumberID { get; set; }
        public DateTime? PrintDate { get; set; }
        public string Line { get; set; }
        public string Shift { get; set; }
        public string SEQ { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
