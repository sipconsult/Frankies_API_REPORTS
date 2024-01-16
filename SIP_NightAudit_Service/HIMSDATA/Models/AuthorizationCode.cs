﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class AuthorizationCode
    {
        public long Id { get; set; }
        public int? ProviderId { get; set; }
        public int? TrackId { get; set; }
        public string Code { get; set; }
        public string InsCompany { get; set; }
        public string CodeUsed { get; set; }
    }
}
