using System;
using System.Collections.Generic;

namespace Atsolution.Efs.Entities
{
    public partial class AccountObjectShippingAddress
    {
        public string ShippingAddressId { get; set; }
        public string AccountObjectId { get; set; }
        public string ShippingAddress { get; set; }
        public int SortOrder { get; set; }
    }
}
