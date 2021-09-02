using MemberRegistiration.DataAccess.Concrate.EntityFramework.Mappigs;
using MemberRegistration.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistiration.DataAccess.Concrate.EntityFramework
{
    public class MemberShipContext : DbContext
    {
        public MemberShipContext()
        {
            Database.SetInitializer<MemberShipContext>(null);
        }

        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
        }
    }
}
