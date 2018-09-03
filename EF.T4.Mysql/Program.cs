using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.T4.Mysql
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContext dbcontext = new DbContext();
            var lst= dbcontext.Company_Shares.ToList();

            var lst2= dbcontext.Plan.Where(x=>x.Id=="sss").ToList();
        }
    }
}
