using SyncDB.Abstract;
using SyncDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDB.Concrete
{
    public class EFSiteMrrRepository : IMrrRepository
    {
        EFDbSiteContext context = new EFDbSiteContext();
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
