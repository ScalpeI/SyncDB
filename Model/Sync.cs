using SyncDB.Concrete;
using SyncDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDB.Model
{
    class Sync
    {
        public void SyncUser()
        {
            EFSiteUserRepository eFSite = new EFSiteUserRepository();
            EFBackUserRepository eFBack = new EFBackUserRepository();
            
            foreach (var fuser in eFSite.Users)
            {
                bool userFindPoint = false;
                bool userChangePoint = false;
                foreach (var buser in eFBack.Users)
                {
                    if (buser.Login == fuser.Login)
                    {
                        userFindPoint = true;
                        if (buser.Mkey!=fuser.Mkey || buser.Msecret != fuser.Msecret || buser.Stoken != fuser.Stoken || buser.Bkey != fuser.Bkey || buser.Bpuid != fuser.Bpuid)
                        {
                            userChangePoint = true;
                        }
                        break;
                    }
                }
                if (!userFindPoint)
                {
                    eFBack.Create(fuser);
                    Console.WriteLine("Add user {0}", fuser.Login);
                }
                if (userFindPoint && userChangePoint)
                {
                    eFBack.Update(fuser);
                    Console.WriteLine("Update user {0}", fuser.Login);
                }
            }
        }

        public void SyncHash()
        {
            EFSiteMrrRepository eFSiteMrr = new EFSiteMrrRepository();
            EFBackMrrRepository eFBackMrr = new EFBackMrrRepository();
            

            List<Mrr> backmrr = eFBackMrr.Mrrs.Where(x => x.date >= DateTime.Now.AddDays(-4)).ToList();
            List<Mrr> sitemrr = eFSiteMrr.Mrrs.Where(x => x.date >= DateTime.Now.AddDays(-4)).ToList();
            foreach (var bmrr in backmrr)
            {
                bool mrrFindPoint = false;
                foreach (var fmrr in sitemrr)
                {
                    if (bmrr.date == fmrr.date && bmrr.idrig == fmrr.idrig && bmrr.owner==fmrr.owner)
                    {
                        //Console.WriteLine("Find hash mrr {0}", fmrr.date);
                        mrrFindPoint = true;
                        break;
                    }
                }
                if (!mrrFindPoint)
                {
                    eFSiteMrr.Create(bmrr);
                    Console.WriteLine("Add hash mrr {0}", bmrr.date);
                }
            }
            EFSiteBtcRepository eFSiteBtc = new EFSiteBtcRepository();
            EFBackBtcRepository eFBackBtc = new EFBackBtcRepository();
            
            List<Btc> backbtc = eFBackBtc.Btcs.Where(x => x.date >= DateTime.Now.AddDays(-3)).ToList();
            List<Btc> sitebtc = eFSiteBtc.Btcs.Where(x => x.date >= DateTime.Now.AddDays(-3)).ToList();

            foreach (var bbtc in backbtc)
            {
                bool btcFindPoint = false;
                foreach (var fbtc in sitebtc)
                {
                    if (bbtc.date == fbtc.date && bbtc.owner == bbtc.owner)
                    {
                        btcFindPoint = true;
                        break;
                    }
                }
                if (!btcFindPoint)
                {
                    eFSiteBtc.Create(bbtc);
                    Console.WriteLine("Add hash btc {0}", bbtc.date);
                }
            }
            EFSiteSpRepository eFSiteSp = new EFSiteSpRepository();
            EFBackSpRepository eFBackSp = new EFBackSpRepository();
            
            List<Sp> backsp = eFBackSp.Sps.Where(x => x.date >= DateTime.Now.AddDays(-3)).ToList();
            List<Sp> sitesp = eFSiteSp.Sps.Where(x => x.date >= DateTime.Now.AddDays(-3)).ToList();

            foreach (var bsp in backsp)
            {
                bool spFindPoint = false;
                foreach (var fsp in sitesp)
                {
                    if (bsp.date == fsp.date && bsp.owner == fsp.owner)
                    {
                        spFindPoint = true;
                        break;
                    }
                }
                if (!spFindPoint)
                {
                    eFSiteSp.Create(bsp);
                    Console.WriteLine("Add hash sp {0}", bsp.date);
                }
            }
        }

        public void SyncEar()
        {

        }
    }
}
