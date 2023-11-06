using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_BookProjectModified.Exceptions
{
    internal class BookNotFoundWithIsbnException: Exception
    {

        public BookNotFoundWithIsbnException(string isbn) :
            base($"No book found with Isbn: {isbn}")
        { }
    }
}
