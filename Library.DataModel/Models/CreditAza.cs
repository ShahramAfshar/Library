using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataModel.Models
{
   public class CreditAza
    {
        [Key]
        public int CreditAzaId  { get; set; }

        [Display(Name = "تاریخ عضویت")]
        public DateTime StartOzviat { get; set; }

        [Display(Name = "اعتبار عضویت")]
        public DateTime EndOzviat { get; set; }

        [Display(Name = "مبلغ پرداخت")]
        public decimal Pay { get; set; }


        public virtual Aza  Aza { get; set; }
        public int AzaId { get; set; }
    }
}
