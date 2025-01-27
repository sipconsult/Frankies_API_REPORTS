﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.DB_Models
{
    public partial class RoomType
    {
        public RoomType()
        {
            Rooms = new HashSet<Room>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
