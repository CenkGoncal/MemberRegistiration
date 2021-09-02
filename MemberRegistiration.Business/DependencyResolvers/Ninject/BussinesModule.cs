using MemberRegistiration.Business.Abstract;
using MemberRegistiration.Business.Concarate;
using MemberRegistiration.Business.ServersAdapters;
using MemberRegistiration.DataAccess.Abstract;
using MemberRegistiration.DataAccess.Concrate.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistiration.Business.DependencyResolvers.Ninject
{
    public class BussinesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMemberDal>().To<EfMemberDal>().InSingletonScope();
            Bind<IMemberService>().To<MemberManager>().InSingletonScope();
            Bind<IKpsService>().To<KpsServerAdapter>().InSingletonScope();
        }
    }
}
