using MemberRegistiration.Core.DataAccess;
using MemberRegistiration.DataAccess.Abstract;
using MemberRegistration.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistiration.DataAccess.Concrate.EntityFramework
{
    public class EfMemberDal : EfEntityRepositoryBase<Member, MemberShipContext>,IMemberDal
    {
    }
}
