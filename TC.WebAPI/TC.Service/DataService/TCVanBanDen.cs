using System;
using System.Collections.Generic;
using System.Text;
using TC.Service.Infrastructure;
using TC.Context;
using TC.Model;
using System.Linq;

namespace TC.Service.DataService
{
    public class TCVanBanDen : ITCVanBanDen
    {
        private readonly TCCoreDBContext _context;
        public TCVanBanDen(TCCoreDBContext context)
        {
            _context = context;            
        }
        public List<VanBanDens> GetVanBanDen()
        {
            return _context.VanBanDen.ToList();
        }
    }
}
