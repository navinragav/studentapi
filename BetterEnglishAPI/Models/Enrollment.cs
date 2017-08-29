using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BetterEnglishAPI.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        [Key]
        [Required]
        [Display(Name = "EnrollmentID")]
        public string EnrollmentID { get; set; }

        public string CourseID { get; set; }
        public string StudentID { get; set; }
        public Grade Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
        public object EnrollmentsID { get; internal set; }
    }
}