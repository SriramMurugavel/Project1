//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmpPortal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    
    
    public partial class signup
    {
        public int id { get; set; }
        [Required]
        [Display(Name ="Name : ")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Employee ID : ")]
        public string empid { get; set; }
        [Required]
        [Display(Name = "Mobile Number : ")]
        public string mobileno { get; set; }
        [Required]
        [Display(Name = "Date of Birth : ")]
        [DataType(DataType.Date)]
        public DateTime dob { get; set; }
        [Required]
        [Display(Name = "Email ID :  ")]
        [DataType(DataType.EmailAddress)]
        //[RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        //ErrorMessage = "Please enter correct email address")]
        public string emailid { get; set; }
        [Required]
        [Display(Name = "Password : ")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage ="Password should contain atleast one uppercase letter, one lowercase letter,one special character and one number")]
        public string password { get; set; }
        [Required]
        [Display(Name = "Confirm Password : ")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Password should contain atleast one uppercase letter, one lowercase letter,one special character and one number")]
        [System.ComponentModel.DataAnnotations.Compare("password", ErrorMessage = "Password Mismatch")]
        public string confirmpassword { get; set; }
        [Required(ErrorMessage ="Choose a question")]
        [Display(Name = "Security Question : ")]
        
        public string securityquestion { get; set; }
        [Required(ErrorMessage ="You must answer for the above question")]
        [Display(Name = "Answer : ")]
        public string securityanswer { get; set; }
    }
}