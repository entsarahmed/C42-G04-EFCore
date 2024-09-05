﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Entities
{
   // [Owned]
    internal class Address
    {
        public int BlockNo {  get; set; }
        public string? Street {  get; set; }
        public string? City { get; set; }

        public string? Country { get; set; }

    }
}
