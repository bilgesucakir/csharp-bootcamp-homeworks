using HW1_ZooManagementSystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Business;

public interface IAnimalService
{
    void GetList();
    void PrintList(List<Animal> list);
    void Add(Animal animal);
    void Update(Animal animal);
    void Delete(int id);
    void GetById(int id);
    void GetByKind(string kind);
    void GetByKeeperId(int keeperId);
    void GetByName(string name);
}
