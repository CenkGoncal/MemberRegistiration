using MemberRegistration.Entites.Concrete;
using Ninject.Modules;
using FluentValidation;
using MemberRegistiration.Business.ValidationRules.FluentValidation;

namespace MemberRegistiration.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Member>>().To<MemberValidator>().InSingletonScope();
        }
    }
}
