﻿using System;
using System.Collections.Generic;

namespace Atsolution.Efs.Entities
{
    public partial class InventoryItemCategory
    {
        public string InventoryCategoryId { get; set; }
        public string InventoryCategoryCode { get; set; }
        public string InventoryCategoryName { get; set; }
        public string CodeCategory { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int SkuIndex { get; set; }
        public string FkInventoryCategory { get; set; }
    }
}
