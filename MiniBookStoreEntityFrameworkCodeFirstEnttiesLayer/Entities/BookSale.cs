using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBookStoreEntityFrameworkCodeFirstEnttiesLayer.Entities
{
    [Table("BookSales")]
    public class BookSale:Base<int>
    {
        public int BookId { get; set; }

        public int Count { get; set; }

        [ForeignKey("BookId")]

      public virtual Book BooK { get; set; }

    }
}
