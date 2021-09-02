using MemberRegistiration.Business.Abstract;
using MemberRegistiration.MVC.Filters;
using MemberRegistiration.MVC.Models;
using MemberRegistration.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberRegistiration.MVC.Controllers
{
    public class HomeController : Controller
    {
        private IMemberService _memberService;
        public HomeController(IMemberService memberService)
        {    
            _memberService = memberService;
        }
        
        public ActionResult Add()
        {
            ViewBag.ErrorMessage = "";
            return View(new MemberAddViewModel());
        }

        [HttpPost]
        [ExceptionHandlerAttribute]
        public ActionResult Add(Member member)
        {
           _memberService.Add(member);

            return View(new MemberAddViewModel());
        }

    }
}