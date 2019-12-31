using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataModel.Models
{
   public class Person
    {
        [Display(Name = "نام")]
        [Required(ErrorMessage = " فیلد{0} نمی تواند خالی باشد")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = " فیلد{0} نمی تواند خالی باشد")]
        public string LastName { get; set; }

        [Display(Name = "سن")]
        [Required(ErrorMessage = " فیلد{0} نمی تواند خالی باشد")]
        public int Age { get; set; }


        [Display(Name = "تاریخ تولد")]
        [Column(TypeName = "datetime2")]
        public DateTime Birthday { get; set; }

        public string BioGraph { get; set; }
        public string ShortDesc { get; set; }
        public Tahsilat  Tahsilat { get; set; }

    }

    public enum Tahsilat
    {
       ZirDiplom,Diplom,foghDiplom,Lisans,Foghlisans,Doctora,Foghdoctora
    }
}
