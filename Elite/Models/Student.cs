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

        public string CurrentProgram { get; set; }

        [Required(ErrorMessage = "MobileNumber is required.")]
        [Phone]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage ="EmailId is required.")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }
        public string PostalCode { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please select the Date.")]
        public DateTime DateEnrolled { get; set; }
        public string Skills { get; set; }

        public string IndustryExperience { get; set; }

        public string LinkedInProfile { get; set; }

        public string GitHubUrl { get; set; }
        public string StackOverflowUrl { get; set; }



    }
}
