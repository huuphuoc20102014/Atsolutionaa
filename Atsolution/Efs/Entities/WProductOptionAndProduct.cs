using System;
using System.Collections.Generic;

namespace Atsolution.Efs.Entities
{
    public partial class WProductOptionAndProduct
    {
        public string FkProductOptionId { get; set; }
        public string FkProductId { get; set; }
        public decimal Price { get; set; }
    }
}
