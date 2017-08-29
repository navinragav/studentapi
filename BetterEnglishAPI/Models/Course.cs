using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BetterEnglishAPI.Models
{
    public enum Type
    {
        GeneralEnglish, CambridgeIELTS
    }
    public enum Level
    {
        Beginner, Intermediate, Advanced
    }

    public enum payment
    {
        Visa, Mastercard
    }
    public class Course
    {
        internal object EnrollmentsID;

        [Key]
        [Required]
        [Display(Name = "CourseID")]
        public string CourseID { get; set; }
        public Type Type { get; set; }

        public Level Level { get; set; }

        [Required]
        [Display(Name = "scheduleIn")]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime scheduleIn { get; set; }
        [Required]
        [Display(Name = "scheduleEnd")]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime scheduleEnd { get; set; }

        public payment payment { get; set; }
        [Required]
        [Display(Name = "cardNo")]
        public string cardNo { get; set; }
        [Required]
        [Display(Name = "ExpiresDate")]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExpiresDate { get; set; }
        [Required]
        [Display(Name = "CardName")]
        [StringLength(16, ErrorMessage = "Full name cannot be longer than 16 characters.")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-za-z]+))$", ErrorMessage = "Enter valid character for full name")]
        public string CardName { get; set; }
        [Required]
        [Display(Name = "CVN")]
        public int CVN { get; set; }

        internal static void ForEach(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}