
using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace EF.T4.Mssql
{
  public partial class DbContext : System.Data.Entity.DbContext
  {
        public DbContext() : base("name=mssqlmaster")
        {
        }    
