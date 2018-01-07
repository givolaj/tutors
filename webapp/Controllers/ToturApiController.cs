﻿using Tutors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace Tutors.Controllers
{
    public class ToturApiController : ApiController
    {
        [HttpGet]
        [Route("getStudentProfile")]
        public IHttpActionResult getStudentProfile()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                string name = User.Identity.Name;
                var profile = db.studentProfiles.FirstOrDefault(x => x.UserName == name);
                if (profile == null) 
                {
                    profile = new StudentProfile()
                    {
                        UserName = name,
                        IsActive = false
                    };
                    db.studentProfiles.Add(profile);
                    db.SaveChanges();
                }
                return Ok(new 
                { 
                    IsActive = profile.IsActive
                });
            }
        }

        public class StudentProfileDto 
        {
            public string IsActive { get; set; }
        }

        [HttpPost]
        [Route("updateStudentProfile")]
        public IHttpActionResult updateStudentProfile(StudentProfileDto profileDto)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                string name = User.Identity.Name;
                var profile = db.studentProfiles.FirstOrDefault(x => x.UserName == name);
                if (profile == null)
                {
                    profile = new StudentProfile()
                    {
                        UserName = User.Identity.Name
                    };
                    db.studentProfiles.Add(profile);                  
                }
                profile.IsActive = profileDto.IsActive.AsBool();
                db.SaveChanges();
                return Ok();
            }
        }
    }
}
