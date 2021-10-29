using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTechProtfolio.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required(ErrorMessage="First Name is required.")]
        [MaxLength(50,ErrorMessage ="First Name should contain maximum fifty characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [MaxLength(50, ErrorMessage = "Last Name should contain more than fifty characters.")]
        public string LastName { get; set; }

        [MaxLength(10)]
        public string CurrentProgram { get; set; }

        [Required(ErrorMessage = "MobileNumber is required.")]
        [Phone]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        [MaxLength(10)]
        public string MobileNo { get; set; }

        [Required(ErrorMessage ="EmailId is required.")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        public string EmailID { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please select the Date.")]
        public DateTime DateEnrolled { get; set; }
        public string Skills { get; set; }

        [MaxLength(20)]
        public string IndustryExperience { get; set; }

        [MaxLength(100)]
        public string LinkedInProfile { get; set; }

        [MaxLength(100)]
        public string GitHubUrl { get; set; }

        [MaxLength(100)]
        public string StackOverflowUrl { get; set; }
    }
}
