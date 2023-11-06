using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_BookProjectModified.Exceptions
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException(int id) :
            base($"İd : {id}, ye ait kitap bulunamadı.") 
        {
        }
       
    }
}
