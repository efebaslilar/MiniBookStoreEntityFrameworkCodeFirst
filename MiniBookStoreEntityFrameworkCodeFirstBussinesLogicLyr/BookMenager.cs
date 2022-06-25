using MiniBookStoreEntityFrameworkCodeFirstDataAccessLayer;
using MiniBookStoreEntityFrameworkCodeFirstEnttiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBookStoreEntityFrameworkCodeFirstBussinesLogicLyr
{
    public class BookMenager:Menager
    {


        public List<Book> GetAllBooks()
        {
            try
            {
                List<Book> data = myContext.BookTable.Where(x => !x.IsDeleted).ToList();
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddNewBook(Book book)
        {
            try
            {
                myContext.BookTable.Add(book);
                myContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void BookSale(int bookCount,Book book)
        {
            try
            {
                //buraya geri doneceğiz.
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
