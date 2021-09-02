using MemberRegistiration.Core.DataAccess;
using MemberRegistration.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistiration.DataAccess.Abstract
{
    public interface IMemberDal : IEntityRepository<Member>
    {
    }
}
