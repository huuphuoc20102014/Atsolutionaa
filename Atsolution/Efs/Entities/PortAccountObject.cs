using System;
using System.Collections.Generic;

namespace Atsolution.Efs.Entities
{
    public partial class PortAccountObject
    {
        public string FkAccountObjectId { get; set; }
        public string FkPortId { get; set; }
        public int SortIndex { get; set; }
        public bool InActive { get; set; }
    }
}
