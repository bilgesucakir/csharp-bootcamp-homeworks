using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Exceptions;

public class AnimalAlreadyExistsException : Exception
{

    public AnimalAlreadyExistsException(int id) :
        base($"An animal with id: {id} already exists.")
    {
    }
}
