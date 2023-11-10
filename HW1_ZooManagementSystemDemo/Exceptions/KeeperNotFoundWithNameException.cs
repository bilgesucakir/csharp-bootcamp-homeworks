using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Exceptions;

public class KeeperNotFoundWithNameException : Exception
{

    public KeeperNotFoundWithNameException(string name) :
        base($"Keeper not fount with name: {name}")
    {
    }

}
