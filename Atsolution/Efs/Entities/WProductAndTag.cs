using System;
using System.Collections.Generic;

namespace Atsolution.Efs.Entities
{
    public partial class WProductAndTag
    {
        public string FkWproduct { get; set; }
        public string FkTag { get; set; }
        public int ShowIndex { get; set; }
    }
}
