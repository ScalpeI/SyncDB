using SyncDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDB.Abstract
{
    public interface IMrrRepository
    {
        IEnumerable<Mrr> Mrrs { get; set; }
        void Create(Mrr mrr);
    }
}
