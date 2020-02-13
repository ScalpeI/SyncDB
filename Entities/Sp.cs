﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDB.Entities
{
    public class Sp
    {
        [Key]
        public int id { get; set; }
        public string owner { get; set; }
        public double hash { get; set; }
        public string type { get; set; }
        public DateTime date { get; set; }
    }
}
