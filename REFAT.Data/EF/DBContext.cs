using Microsoft.EntityFrameworkCore;
using REFAT.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace REFAT.Data.EF
{
    public class DBContext : DbContext
    {

        //ملف الداتا بيز لازم نعطيها نص الاتصال و الجداول
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConString = "server = (local) ; Database = Refat_DB ; Encrypt=false ;  Trusted_Connection = True ";
          //  string ConString = "server = DESKTOP-I83NMPI ; Database = Refat_DB ; Encrypt=false ;  Trusted_Connection = True ";


            optionsBuilder.UseSqlServer(ConString);
        }

        //Tables

        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<SystemRecords> SystemRecords { get; set; }
        public DbSet<SalaryRate> SalaryRate { get; set; }
        public DbSet<Employes> Employes { get; set; }

    }
}
//Add-Migration
//إعطاء اسم
// Update-DataBase