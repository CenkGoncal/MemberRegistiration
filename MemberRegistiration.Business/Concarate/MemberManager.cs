using MemberRegistiration.Business.Abstract;
using MemberRegistiration.Business.ServersAdapters;
using MemberRegistiration.Business.ValidationRules.FluentValidation;
using MemberRegistiration.DataAccess.Abstract;
using MemberRegistration.Entites.Concrete;

namespace MemberRegistiration.Business.Concarate
{
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;
        private IKpsService _kpsService;

        public MemberManager(IMemberDal memberDal, IKpsService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }

        public void Add(Member member)
        {
            CheckUserExits(member);
            CheckValidStructre(member);
            CheckValidateMemberKps(member);

            _memberDal.Add(member);
        }

        private void CheckUserExits(Member member)
        {
            if (_memberDal.Get(w => w.TcNo == member.TcNo) != null)
            {
                throw new System.Exception("Aynı Tc'e Sahip Kullanıcı Mevcuttur");
            }
        }

        private void CheckValidStructre(Member member)
        {
            MemberValidator membervaldation = new MemberValidator();

            var validateResult = membervaldation.Validate(member);
            if (validateResult.IsValid == false)
            {
                throw new System.Exception(validateResult.Errors.ToString());
            }
        }

        private void CheckValidateMemberKps(Member member)
        {
            if (!_kpsService.ValideteUser(member))
            {
                throw new System.Exception("Kullanici doğrulaması geçerli değil");
            }
        }
    }
}
