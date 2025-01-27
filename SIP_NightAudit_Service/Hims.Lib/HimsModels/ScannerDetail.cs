﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class ScannerDetail
    {
        public int RecordId { get; set; }
        public int ClaimId { get; set; }
        public string PageNumber { get; set; }
        public byte[] Page { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
