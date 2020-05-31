using System;
using System.Collections.ObjectModel;

namespace LocalDev.Core.Domain
{
    public class User : Base
    {
        #region Fields
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public GlobalConstants.GenderValue Gender { get; set; }
        public string Note { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion

        #region Initial and Validate
        public override bool IsValidInformation()
        {
            if (string.IsNullOrEmpty(this.Username) ||
                string.IsNullOrEmpty(this.Password) ||
                string.IsNullOrEmpty(this.FullName)) return false;
            return true;
        }
        public override void InitDefaultValues()
        {
            this.Gender = GlobalConstants.GenderValue.Male;
            this.Status = GlobalConstants.StatusValue.Using;
        }
        #endregion
    }
}
