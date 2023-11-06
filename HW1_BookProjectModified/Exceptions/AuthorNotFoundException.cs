using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_BookProjectModified.Exceptions;

public class AuthorNotFoundException : Exception
{
    public AuthorNotFoundException(int id) :
        base($"Author not found with Id: {id}")
    {
    }

}