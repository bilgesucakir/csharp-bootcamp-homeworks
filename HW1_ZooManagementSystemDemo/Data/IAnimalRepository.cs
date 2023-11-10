using HW1_ZooManagementSystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Data;

public interface IAnimalRepository : IEntityBaseRepository<Animal, int>
{
    public List<Animal> GetByKind(string kind);

    public List<Animal> GetByKeeperId(int keeperId);

    public List<Animal> GetByName(string name);
}
