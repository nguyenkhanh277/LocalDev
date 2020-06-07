using System;
using System.Collections.ObjectModel;

namespace LocalDev.Core.Domain
{
    public class ScanBarcode : Base
    {
        #region Fields
        public string Id { get; set; }
        public string WorkOrder { get; set; }
        public string PartNo { get; set; }
        public string Model { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public double Quantity { get; set; }
        public string UserID { get; set; }
        public GlobalConstants.ProductionStatusValue ProductionStatus { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
