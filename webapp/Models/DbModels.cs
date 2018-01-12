using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tutors.Models
{

    public class StudentProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
    }

    public class UserProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageURL { get; set; }
    }

    public partial class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
            : base("name=DefaultConnection")
        {
            
        }

        public DbSet<UserProfile> userProfiles { get; set; }       
        public DbSet<StudentProfile> studentProfiles { get; set; }
      
    }
}