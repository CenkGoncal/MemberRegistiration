using MemberRegistration.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistiration.DataAccess.Concrate.EntityFramework.Mappigs
{
    public class MemberMap : EntityTypeConfiguration<Member>    
    {
        //ToTable(@"Members", @"dbo");
        public MemberMap()
        {
            ToTable("Members", "dbo");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id");
            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.DateOfBirth).HasColumnName("DateOfBirth");
            Property(x => x.TcNo).HasColumnName("TcNo");
            Property(x => x.Email).HasColumnName("Email");
        }      
        
    }


}
