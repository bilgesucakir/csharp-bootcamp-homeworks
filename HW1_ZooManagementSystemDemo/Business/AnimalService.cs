using HW1_ZooManagementSystemDemo.Data;
using HW1_ZooManagementSystemDemo.Exceptions;
using HW1_ZooManagementSystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Business;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;
    private readonly IKeeperRepository _keeperRepository;

    public AnimalService(IAnimalRepository animalRepository, IKeeperRepository keeperRepository)
    {
        _animalRepository = animalRepository;
        _keeperRepository = keeperRepository;
    }

    public void Add(Animal animal)
    {
        try
        {
            bool tryToAdd = true;
            int? keeperId = animal.KeeperId;
            if (keeperId != null)
            {
                int nonNullableKeeperId = keeperId.GetValueOrDefault(-1);
                try
                {
                    Keeper? keeper = _keeperRepository.GetById(nonNullableKeeperId);
                }
                catch (KeeperNotFoundException ex)
                {
                    Console.WriteLine("Cannot add animal since keeper id received from animal object noes not exist in keepers.");
                    tryToAdd = false;
                }
            }
            
            if(tryToAdd)
            {
                _animalRepository.Add(animal);
                Console.WriteLine("Animal added with id: " + animal.Id);

                GetList();
            }   
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Update(Animal animal)
    {

        try
        {
            bool tryToUpdate = true;
            int? keeperId = animal.KeeperId;
            if (keeperId != null)
            {
                int nonNullableKeeperId = keeperId.GetValueOrDefault(-1);
                try
                {
                    Keeper? keeper = _keeperRepository.GetById(nonNullableKeeperId);
                }
                catch (KeeperNotFoundException ex)
                {
                    Console.WriteLine("Cannot update animal since keeper id received from animal object noes not exist in keepers.");
                    tryToUpdate = false;
                }
            }

            if (tryToUpdate)
            {
                _animalRepository.Update(animal);
                Console.WriteLine("Animal updated with id: " + animal.Id);

                GetList();
            }
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
            _animalRepository.Delete(id);
            Console.WriteLine("Animal deleted with id: " + id);
            GetList();
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
            Animal? animal = _animalRepository.GetById(id);
            Console.WriteLine("Animal found with id: "+ id + "\n" + animal);
        }
        catch (AnimalNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void GetByKind(string kind)
    {
        try
        {
            List<Animal> matchedAnimals = _animalRepository.GetByKind(kind);
            Console.WriteLine("Animal(s) found with kind: " + kind);
            PrintList(matchedAnimals);
        }
        catch (AnimalNotFoundWithKindException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    public void GetByKeeperId(int keeperId)
    {
        try
        {
            List<Animal> matchedAnimals = _animalRepository.GetByKeeperId(keeperId);
            Console.WriteLine("Animal(s) found with keeper id: " + keeperId);
            PrintList(matchedAnimals);
        }
        catch (AnimalNotFoundWithKeeperException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void GetByName(string name)
    {
        try
        {
            List<Animal> matchedAnimals = _animalRepository.GetByName(name);
            Console.WriteLine("Animal(s) found with name: " + name);
            PrintList(matchedAnimals);
        }
        catch (AnimalNotFoundWithNameException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void GetList()
    {
        List<Animal> animals = _animalRepository.GetAll();
        PrintList(animals);
    }

    public void PrintList(List<Animal> list)
    {
        list.ForEach(animal => Console.WriteLine(animal));
    }

}
