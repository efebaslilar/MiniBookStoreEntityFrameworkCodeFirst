using MiniBookStoreEntityFrameworkCodeFirstDataAccessLayer;
using MiniBookStoreEntityFrameworkCodeFirstEnttiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBookStoreEntityFrameworkCodeFirstBussinesLogicLyr
{
    public class AuthorMenager
    {
        private MyContext authoorContext = new MyContext();

        public List<Author> GetAllAuthors()
        {
            try
            {
                List<Author> data = authoorContext.AuthorTable.Where(x => !x.IsDeleted).ToList();
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

       
    }
}
