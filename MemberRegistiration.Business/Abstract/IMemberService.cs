﻿using MemberRegistration.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistiration.Business.Abstract
{
    public interface IMemberService
    {
        void Add(Member member);
    }
}
