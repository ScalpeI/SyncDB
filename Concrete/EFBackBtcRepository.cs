﻿using SyncDB.Abstract;
using SyncDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDB.Concrete
{
    class EFBackBtcRepository : IBtcRepository
    {
        EFDbBackContext context = new EFDbBackContext();
        public IEnumerable<Btc> Btcs
        {
            get { return context.Btcs; }
            set { }
        }
        public void Create(Btc btc)
        {
            context.Btcs.Add(btc);
            context.SaveChanges();
        }
    }
}
