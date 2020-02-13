﻿using SyncDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDB.Abstract
{
    public interface IMinearRepository
    {
        IEnumerable<Minear> Minears { get; set; }
        void Create(Minear minear);
    }
}
