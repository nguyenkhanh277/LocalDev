using System;
using System.Collections.ObjectModel;

namespace LocalDev.Core.Domain
{
    public class RegistBarcode : Base
    {
        #region Fields
        public string Id { get; set; }
        public string PartNo { get; set; }
        public DateTime? RegistDate { get; set; }
        public string MachineNo { get; set; }
        public string ShiftNo { get; set; }
        public string MoldNo { get; set; }
        public string SEQ { get; set; }
        public string Barcode { get; set; }
        public string UserID { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
