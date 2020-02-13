using SyncDB.Abstract;
using SyncDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDB.Concrete
{
    class EFBackMrrRepository : IMrrRepository
    {
        EFDbBackContext context = new EFDbBackContext();
        public IEnumerable<Mrr> Mrrs
        {
            get { return context.Mrrs; }
            set { }
        }
        public void Create(Mrr mrr)
        {
            context.Mrrs.Add(mrr);
            context.SaveChanges();
        }
    }
}
