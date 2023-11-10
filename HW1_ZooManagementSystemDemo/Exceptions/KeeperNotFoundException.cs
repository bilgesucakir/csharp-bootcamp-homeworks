using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Exceptions;

public class KeeperNotFoundException : Exception
{

    public KeeperNotFoundException(int id) :
        base($"Keeper not found with id: {id}")
    {
    }
}
