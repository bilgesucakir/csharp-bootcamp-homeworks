using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Exceptions;

public class AnimalNotFoundWithKindException : Exception
{

    public AnimalNotFoundWithKindException(string kind) :
        base($"Animal not found with kind: {kind}")
    {
    }
}
