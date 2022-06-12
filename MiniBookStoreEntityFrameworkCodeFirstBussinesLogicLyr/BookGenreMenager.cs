using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniBookStoreEntityFrameworkCodeFirstDataAccessLayer;
using MiniBookStoreEntityFrameworkCodeFirstEnttiesLayer.Entities;


namespace MiniBookStoreEntityFrameworkCodeFirstBussinesLogicLyr
{
    public class BookGenreMenager
    {
        private MyContext bookContext = new MyContext();

        public List<BookGenre> BringAlltheBookGenres()
        {
            try
            {
                List<BookGenre> list = new List<BookGenre>();
                list = bookContext.BookGenreTable.ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddNewBookGenre(BookGenre bookGenre)
        {
            try
            {
                bookContext.BookGenreTable.Add(bookGenre);
                bookContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
