using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CommForStudent.Models.LoginModels
{
    public class LoginStudent
    {
        [Display(Name ="Diákigazolvány száma:")]
        [Range(10000000000,99999999999,ErrorMessage ="Szükséges a belépéshez a diákigazolvány száma.")]
        public int SCN { get; set; }
       
        [Display(Name ="Jelszó")]
        [DataType(DataType.Password)]
        [StringLength(100,MinimumLength =10,ErrorMessage ="Minimum 10 karakter hosszú jelszóra van szükség.")]
        public string Password { get; set; }
    }
}