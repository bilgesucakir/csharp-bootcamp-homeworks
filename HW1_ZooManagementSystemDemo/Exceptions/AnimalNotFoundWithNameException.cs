using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Exceptions;

public class AnimalNotFoundWithNameException : Exception
{

    public AnimalNotFoundWithNameException(string name) :
        base($"Animal not found with name: {name}")
    {
    }
}
