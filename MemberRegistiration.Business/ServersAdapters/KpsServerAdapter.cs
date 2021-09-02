using MemberRegistration.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistiration.Business.ServersAdapters
{
    public class KpsServerAdapter : IKpsService
    {
        public bool ValideteUser(Member member)
        {
            KpsServiceReference.KPSPublicSoapClient client = new KpsServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(member.TcNo), member.FirstName, member.LastName, member.DateOfBirth.Year);
        }
    }
}
