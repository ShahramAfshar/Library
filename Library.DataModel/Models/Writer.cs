using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataModel.Models
{
  public  class Writer:Person
    {
        [Key]
        public int WriterId { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
