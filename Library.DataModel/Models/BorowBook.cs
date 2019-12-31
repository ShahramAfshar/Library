using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataModel.Models
{
   public class BorowBook
    {
        [Key]
        public int BorowBookId { get; set; }

            [Display(Name = "تاریخ امانت")]
        public DateTime Start { get; set; }

        [Display(Name = "تاریخ تحویل")]
        public DateTime End { get; set; }

        [Display(Name = "برگشت داده شده")]
        public bool IsReturn { get; set; }



        public virtual ExistBook ExistBook { get; set; }
        public int ExistBookId { get; set; }

        public virtual Aza Aza { get; set; }
        public int AzaId { get; set; }
    }
}
