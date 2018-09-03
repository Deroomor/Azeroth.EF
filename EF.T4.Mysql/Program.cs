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

            Company_Shares cs = new Company_Shares() {  Id=Guid.NewGuid().ToString().Substring(0,32),
             Tenant_Id= Guid.NewGuid().ToString().Substring(0, 32)
             , Total_Shares=200};

            dbcontext.Entry(cs).State = System.Data.Entity.EntityState.Added;
            dbcontext.SaveChanges();

            var lst= dbcontext.Company_Shares.ToList();

            var lst2= dbcontext.Plan.Where(x=>x.Id=="sss").ToList();

       
            System.Data.DataTable table = new System.Data.DataTable();
            //string inheritFlag = "sssssssssss";
            //bool isInherit= table.Columns.OfType<System.Data.DataColumn>().Any(x => x.ColumnName.ToLower() == inheritFlag);
        }
    }
}
