using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBookStoreEntityFrameworkCodeFirstEnttiesLayer.Entities
{

    [Table("Author")]
   public class Author:Base<int>, INameable
    {
        [Required(ErrorMessage ="Yazar adı boş geçilemez!")]
        [StringLength(50,ErrorMessage ="Yazar adı max 50 karakter olamalıdır!")]
        public string Name { get; set; } 

        [StringLength(50,ErrorMessage = "Yazar adı max 50 karakter olamalıdır!")]
        public string Surname { get; set; }

        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        //Bir yazarın birden çok kitabı olabilir.
        public virtual List<Book> AuthorBooks { get; set;}
    }
}
