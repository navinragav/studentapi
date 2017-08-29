using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BetterEnglishAPI.Models
{
    public enum Gender { Male, Female }
    public class Student
    {
        [Key]
        [Required]
        [Display(Name = "StudentID")]
        public string StudentID { get; set; }

        [Required]
        [Display(Name = "Date")]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "FirstName")]
        [StringLength(40, ErrorMessage = "Full name cannot be longer than 40 characters.")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-za-z]+))$", ErrorMessage = "Enter valid character for full name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "LastName")]
        [StringLength(40, ErrorMessage = "Full name cannot be longer than 40 characters.")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-za-z]+))$", ErrorMessage = "Enter valid character for full name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "DOB")]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        public Gender Gender { get; set; }
        [Required]
        [Display(Name = "Education")]
        public string Education { get; set; }

        [Required]
        [Display(Name = "ContactNumber")]
        public int ContactNumber { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }

    }
}