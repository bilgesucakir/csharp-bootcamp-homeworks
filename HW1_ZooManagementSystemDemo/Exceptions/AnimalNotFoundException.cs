using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Exceptions;

public class AnimalNotFoundException : Exception
{

    public AnimalNotFoundException(int id) :
        base($"Animal not found with id: {id}")
    {
    }
}
