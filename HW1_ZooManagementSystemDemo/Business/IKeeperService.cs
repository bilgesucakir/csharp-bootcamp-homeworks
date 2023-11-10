using HW1_ZooManagementSystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Business;

public interface IKeeperService
{
    void GetList();
    void PrintList(List<Keeper> list);
    void Add(Keeper keeper);
    void Update(Keeper keeper);
    void Delete(int id);
    void GetById(int id);
    void GetByName(string name);
    void GetByAnimalId(int id);
}
