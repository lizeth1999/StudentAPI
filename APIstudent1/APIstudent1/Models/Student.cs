using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIstudent1.Models
{
    public class Student
    {
        [Key]
        [Required]
        [Range(1,9999)]
        public int StudentID { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage ="YOU MUST ENTER THE FIELD {0}")]
        public string LastName { get; set; }

        [StringLength(30,ErrorMessage ="THE FIELD {0} MUST CONTAIN BETWEEN  {2} AND {1} CHARACTERS",MinimumLength =2)]
        [Required(ErrorMessage = "YOU MUST ENTER THE FIELD {0}")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}",ApplyFormatInEditMode =true)]
        public DateTime EnrollmentDate { get; set; }

    }
}