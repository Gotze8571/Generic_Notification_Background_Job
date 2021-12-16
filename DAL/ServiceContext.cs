using Notification_Service.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Service.DAL
{
    public class ServiceContext : DbContext
    {
        public ServiceContext() : base("SqlConnection")
        {
        }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        //public DbSet<AirtimeInstruction> AirtimeInstructions { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
