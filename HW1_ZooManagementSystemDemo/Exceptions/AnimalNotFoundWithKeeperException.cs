using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Exceptions;

public class AnimalNotFoundWithKeeperException : Exception
{

    public AnimalNotFoundWithKeeperException(int keeperId) :
        base($"Animal not found with keeper id: {keeperId}")
    {
    }
}
