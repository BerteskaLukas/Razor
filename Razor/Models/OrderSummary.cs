﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Models
{
    public class OrderSummary
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
