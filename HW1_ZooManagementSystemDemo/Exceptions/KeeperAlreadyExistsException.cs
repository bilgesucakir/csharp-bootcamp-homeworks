using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Exceptions;

public class KeeperAlreadyExistsException : Exception
{
    public KeeperAlreadyExistsException(int id) :
        base($"A keeper with id: {id} already exists.")
    {
    }
}
