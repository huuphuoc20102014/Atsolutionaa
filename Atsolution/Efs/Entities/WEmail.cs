﻿using System;
using System.Collections.Generic;

namespace Atsolution.Efs.Entities
{
    public partial class WEmail
    {
        public string Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string EmailAddress { get; set; }
    }
}
