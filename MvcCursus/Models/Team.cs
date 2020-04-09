﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCursus.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Membership> Memberships { get; set; }

    }
}
