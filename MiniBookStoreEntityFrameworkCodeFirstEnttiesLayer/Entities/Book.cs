using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBookStoreEntityFrameworkCodeFirstEnttiesLayer.Entities
{
    [Table("Books")]
    public class Book:Base<int>
    {
        public string ISBN { get; set; }

        [Required(ErrorMessage ="Kitap ismi boş bırakılmaz")]
        [StringLength(100,ErrorMessage ="Kitap İsmi maksimum 100 karakter olmadılır.")]
        public string BookName { get; set; }

        public int GenreId { get; set; }
        
        public int AuthorId { get; set; }
        
        public int PublicationYear { get; set; }

    }
}
