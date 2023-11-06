using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW1_BookProjectModified.Consts;

namespace HW1_BookProjectModified.Exceptions;

public class AuthorNameException : Exception
{

    public AuthorNameException(string name)
        : base(Messages.AuthorNameExceptionMessage(name))
    {

    }



}
