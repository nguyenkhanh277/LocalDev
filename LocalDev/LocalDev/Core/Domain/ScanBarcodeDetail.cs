using System;
using System.Collections.ObjectModel;

namespace LocalDev.Core.Domain
{
    public class ScanBarcodeDetail : Base
    {
        #region Fields
        public string Id { get; set; }
        public string ScanBarcodeId { get; set; }
        public DateTime? ProducedDate { get; set; }
        public string Barcode { get; set; }
        public string PartNo { get; set; }
        public string ShiftNo { get; set; }
        public string MachineNo { get; set; }
        public string UserID { get; set; }
        public GlobalConstants.ResultStatusValue ResultStatus { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
