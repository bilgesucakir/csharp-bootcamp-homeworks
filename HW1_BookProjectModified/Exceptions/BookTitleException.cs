using HW1_BookProjectModified.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_BookProjectModified.Exceptions;
public class BookTitleException : Exception
{
    public BookTitleException(string title) : base(Messages.BookTitleExceptionMessage(title)) { }
    
}
