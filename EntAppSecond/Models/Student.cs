using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EntAppSecond
{
 

    public class Student
    {
        //properties
       
        [Required (ErrorMessage = "Please enter a student ID")]
        [Display(Name = "Student ID")]
        [RegularExpression(@"(s|S)\d{7}")]
        public string StudentID { get; set; } ="";

        [Required]
        [Display(Name = "First Name")]
        [RegularExpression(@"\w{2,50}")]
        public string FirstName { get; set; } = "";

        [Required]
        [Display(Name = "Last Name")]
        [RegularExpression(@"\w{3,50}")]
        public string LastName { get; set; } = "";


        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of births")]
        public DateTime DateOfBirth { get; set; } 

        [Required]
        [Display(Name = "Number of modules taken this year")]
        [RegularExpression(@"[2-9]|([1-9][0-9]+)")]
        public int NumberModules { get; set; }

        [Required]
        [Display(Name = "Height in cm")]
        [RegularExpression(@"([5-8][0-9]|9[0-9]|1[0-9]{2}|2[0-4][0-9]|250)")]
        public decimal Height { get; set; }

        [Required]
        [Display(Name = "Email")]
        [RegularExpression(@"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b")]
        public string Email { get; set; } = "";

        [Required]
        [Display(Name = "Confirm Email")]
        [RegularExpression(@"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b")]
        public string EmailConfirm { get; set; } = "";


    }

    

    
}
