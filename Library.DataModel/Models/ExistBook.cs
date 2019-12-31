using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataModel.Models
{
    public class ExistBook
    {
        [Key]
        public int ExistBookId { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatDate { get; set; }

        [Display(Name = "تعداد موجود")]
        public int Count { get; set; }

    }
}
