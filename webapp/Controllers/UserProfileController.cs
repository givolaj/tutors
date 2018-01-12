using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutors.Models;

namespace Tutors.Controllers
{
    public class UserProfileController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserProfileIndex()
        {
            return View();
        }

        public ActionResult StudentProfile()
        {
            return View();
        }

        public ActionResult TeacherProfile()
        {
            return View();
        }
    }
}