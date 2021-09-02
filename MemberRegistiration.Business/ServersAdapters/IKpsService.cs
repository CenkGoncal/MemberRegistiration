using MemberRegistration.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistiration.Business.ServersAdapters
{
    public interface IKpsService
    {
        bool ValideteUser(Member member);
    }
}
