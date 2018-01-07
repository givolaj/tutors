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

    public partial class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
            : base("name=DefaultConnection")
        {
            
        }
    
        public DbSet<StudentProfile> studentProfiles { get; set; }
      
    }
}