
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataModel.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Display(Name = "تعداد چاپ")]
        public int CountPrint { get; set; }

        [Display(Name = "تعداد ویراست")]
        public int CountEdit { get; set; }

        [Display(Name = "تاریخ ثبت")]
        public DateTime CreatDate { get; set; }


        public virtual Writer  Writer { get; set; }
        public int WriterId { get; set; }

        public virtual ExistBook  ExistBook { get; set; }


    }
}
