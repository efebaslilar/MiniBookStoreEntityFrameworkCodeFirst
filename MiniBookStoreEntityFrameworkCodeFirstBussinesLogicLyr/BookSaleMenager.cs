using MiniBookStoreEntityFrameworkCodeFirstEnttiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBookStoreEntityFrameworkCodeFirstBussinesLogicLyr
{
    public class BookSaleMenager:Menager
    {

        public void AddBookSale(BookSale bookSale)
        {
            try
            {
                myContext.BookSaleTable.Add(bookSale);
                myContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
