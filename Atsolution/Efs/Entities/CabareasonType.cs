using System;
using System.Collections.Generic;

namespace Atsolution.Efs.Entities
{
    public partial class CabareasonType
    {
        public int ReasonTypeId { get; set; }
        public int RefType { get; set; }
        public string ReasonTypeName { get; set; }
        public string Description { get; set; }
    }
}
