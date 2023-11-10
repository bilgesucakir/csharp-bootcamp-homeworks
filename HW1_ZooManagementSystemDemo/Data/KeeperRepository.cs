using HW1_ZooManagementSystemDemo.Exceptions;
using HW1_ZooManagementSystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Data;

public class KeeperRepository : IKeeperRepository
{
    private readonly List<Keeper> _keeperData;

    public KeeperRepository()
    {

        // Seed Data
        _keeperData = new List<Keeper>()
        {
            new Keeper{Id=1, Name="Keeper1", Age=30, Gender="Female"},
            new Keeper{Id=2, Name="Keeper2", Age=40, Gender="Male"},
            new Keeper{Id=3, Name="Keeper3", Age=27, Gender="Male"},
            new Keeper{Id=4, Name="Keeper4", Age=38, Gender="Female"}
        };
    }

    public void Add(Keeper keeper)
    {
        
        int idKeeper = keeper.Id;
        int index = _keeperData.FindIndex(keeper => keeper.Id == idKeeper);

        if (index != -1)
        {
            throw new KeeperAlreadyExistsException(idKeeper);
        }
        _keeperData.Add(keeper);
    }

    public void Update(Keeper keeper)
    {
        int idKeeper = keeper.Id;
        int index = _keeperData.FindIndex(keeper => keeper.Id == idKeeper);

        if(index == -1){
            throw new KeeperNotFoundException(idKeeper);
        }

        _keeperData[index] = keeper;
    }


    public void Delete(int id)
    {
        Keeper? keeper = _keeperData.Where(x => x.Id == id).SingleOrDefault();
        if (keeper == null)
        {
            throw new KeeperNotFoundException(id);
        }
        _keeperData.Remove(keeper);
    }

    public List<Keeper> GetAll()
    {
        return _keeperData;
    }

    public List<Keeper> GetByName(string name)
    {
        List<Keeper> keeper = _keeperData.Where(x => x.Name == name).ToList();

        if (keeper.Count == 0)
        {
            //throw new KeeperNotFoundWithNameException(id);
        }
        return keeper;
    }

    public Keeper? GetById(int id)
    {
        Keeper? keeper = _keeperData.SingleOrDefault(x => x.Id == id);

        if (keeper == null)
        {
            throw new KeeperNotFoundException(id);
        }
        return keeper;
    }


}
