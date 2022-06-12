using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBookStoreEntityFrameworkCodeFirstEnttiesLayer.Entities
{
    [Table("BookGenre")]
    class BookGenre : Base<Byte>
    {
        [Required(ErrorMessage = "Kitap türü boş geçilemez!")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Kitap Türü 2-50 karakter arasında olmalıdır.")]
        public string GenreName { get; set; }
    }
}
