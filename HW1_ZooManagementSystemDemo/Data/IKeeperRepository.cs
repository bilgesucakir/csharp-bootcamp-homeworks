using HW1_ZooManagementSystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Data;

public interface IKeeperRepository : IEntityBaseRepository<Keeper, int>
{


    public List<Keeper> GetByName(string name);
}
