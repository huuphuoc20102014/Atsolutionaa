using System;
using System.Collections.Generic;

namespace Atsolution.Efs.Entities
{
    public partial class ConfigListTable
    {
        public string ConfigListTableId { get; set; }
        public int Reftype { get; set; }
        public string GeneralTableName { get; set; }
        public string ListCode { get; set; }
        public string ListTableName { get; set; }
        public string Description { get; set; }
    }
}
