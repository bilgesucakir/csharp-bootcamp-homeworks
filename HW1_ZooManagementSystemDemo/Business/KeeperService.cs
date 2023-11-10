using HW1_ZooManagementSystemDemo.Data;
using HW1_ZooManagementSystemDemo.Exceptions;
using HW1_ZooManagementSystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Business;

public class KeeperService : IKeeperService
{

    private readonly IKeeperRepository _keeperRepository;
    private readonly IAnimalRepository _animalRepository;

    public KeeperService(IKeeperRepository keeperRepository, IAnimalRepository animalRepository)
    {
        _keeperRepository = keeperRepository;
        _animalRepository = animalRepository;
    }

    public void Add(Keeper keeper)
    {
        try
        {
            _keeperRepository.Add(keeper);
            Console.WriteLine("Keeper added with id: " + keeper.Id);

            GetList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Update(Keeper keeper)
    {
        try
        {
            _keeperRepository.Update(keeper);
            Console.WriteLine("Keeper updated with id: " + keeper.Id);

            GetList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _keeperRepository.Delete(id);

            Console.WriteLine("Keeper deleted with id: " + id);
            GetList();


            try
            {
                List<Animal> animalsWithTheKeeper = _animalRepository.GetByKeeperId(id);
                try
                {
                    animalsWithTheKeeper.ForEach(animal =>
                    {
                        Animal newAnimal = new Animal
                        {
                            Id = animal.Id,
                            Age = animal.Age,
                            AtZooSince = animal.AtZooSince,
                            Kind = animal.Kind,
                            Name = animal.Name,
                            KeeperId = null
                        };

                        _animalRepository.Update(newAnimal);
                    });
                    Console.WriteLine("Animals updated accorindly");

                    List<Animal> animals = _animalRepository.GetAll();
                    animals.ForEach(animal => Console.WriteLine(animal));
                }
                catch (AnimalNotFoundException ex)
                {
                    //added as a precaution bu this code block should not be entered 
                    Console.WriteLine(ex.Message);
                }
            }
            catch (AnimalNotFoundWithKeeperException ex)
            {
                //no action needed, a keeper may not be assigned to any animal before deletion
                Console.WriteLine("No animal record will be updated since no animal exists with deleted keepers id");
            }


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(int id)
    {
        try
        {
            Keeper? keeper = _keeperRepository.GetById(id);
            Console.WriteLine("Keeper found with id: " + id + "\n" + keeper);
        }
        catch (KeeperNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    public void GetByName(string name)
    {
        try
        {
            List<Keeper> matchedKeepers = _keeperRepository.GetByName(name);
            Console.WriteLine("Keeper(s) found with name: " + name);
            PrintList(matchedKeepers);
        }
        catch (KeeperNotFoundWithNameException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetByAnimalId(int id)
    {
        try
        {
            Animal? animal = _animalRepository.GetById(id);

            int? keeperId = animal.KeeperId;
            int nonNullableKeeperId = keeperId.GetValueOrDefault(-1);

            try
            {
                Keeper? keeper = _keeperRepository.GetById(nonNullableKeeperId);
                Console.WriteLine($"Keeper found with given animal id: {id}\n" + keeper);
            }
            catch (KeeperNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        catch (AnimalNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetList()
    {
        List<Keeper> keepers = _keeperRepository.GetAll();
        PrintList(keepers);
    }

    public void PrintList(List<Keeper> list)
    {
        list.ForEach(keeper => Console.WriteLine(keeper));
    }
}
