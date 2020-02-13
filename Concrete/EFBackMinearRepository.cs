using SyncDB.Abstract;
using SyncDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDB.Concrete
{
    class EFBackMinearRepository : IMinearRepository
    {
        EFDbBackContext context = new EFDbBackContext();
        public IEnumerable<Minear> Minears
        {
            get { return context.Minears; }
            set { }
        }
        public void Create(Minear minear)
        {
            context.Minears.Add(minear);
            context.SaveChanges();
        }
    }
}
