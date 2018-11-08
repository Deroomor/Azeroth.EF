
using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace EF.T4.Mssql.ZS
{
  public partial class DbContextDebug : System.Data.Entity.DbContext
  {
        public DbContextDebug() : base("name=GZDbContext")
        {
        }    
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_ApproveLog> GZ_ApproveLog { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_Attachment> GZ_Attachment { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_Attendance> GZ_Attendance { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_AttendanceDetail> GZ_AttendanceDetail { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_Bonus> GZ_Bonus { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_Company> GZ_Company { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_Department> GZ_Department { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_Employee> GZ_Employee { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_EmployeeSalary> GZ_EmployeeSalary { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_FinancialUnit> GZ_FinancialUnit { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_Function> GZ_Function { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_FunctionGroup> GZ_FunctionGroup { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_FunctionGroupRight> GZ_FunctionGroupRight { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_HouseMoneyDetail> GZ_HouseMoneyDetail { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_HouseMoneyMaster> GZ_HouseMoneyMaster { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_MonthlySalaryDetail> GZ_MonthlySalaryDetail { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_MonthlySalaryMaster> GZ_MonthlySalaryMaster { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_Role> GZ_Role { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_ShortSalary> GZ_ShortSalary { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_SMS> GZ_SMS { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_SocialMoneyDetailGZ> GZ_SocialMoneyDetailGZ { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_SocialMoneyDetailSZ> GZ_SocialMoneyDetailSZ { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_SocialMoneyMasterGZ> GZ_SocialMoneyMasterGZ { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_SocialMoneyMasterSZ> GZ_SocialMoneyMasterSZ { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_UpdateHistory> GZ_UpdateHistory { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_User> GZ_User { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_UserFunctionRight> GZ_UserFunctionRight { get; set; }
    /// <summary>
    /// 
    /// <summary>
    public virtual DbSet<GZ_UserRole> GZ_UserRole { get; set; }
    }
}
