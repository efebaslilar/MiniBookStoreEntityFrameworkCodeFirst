using MiniBookStoreEntityFrameworkCodeFirstEnttiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBookStoreEntityFrameworkCodeFirstDataAccessLayer
{
    public class MyContext : DbContext
    {
        //constructor yazdık
        //base e connection string cümlesinin olduğu parametre verdik.
        public MyContext():base("name=MyCon")
        {}

        //Ne kadar tablomuz varsa o tabloları sanal olarak karşılayacak
        //DBSet propertylerini buraya tanımlıyoruz
        public virtual DbSet<Book> BookTable { get; set; } //Adonet datatable
        public virtual DbSet<BookGenre> BookGenreTable { get; set; }
        public virtual DbSet<Author> AuthorTable { get; set; }

        public virtual DbSet<BookSale> BookSaleTable { get; set; }



    }
}
