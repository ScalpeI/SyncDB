using SyncDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDB.Abstract
{
    public interface IBtcRepository
    {
        IEnumerable<Btc> Btcs { get; set; }
        void Create(Btc btc);
    }
}
