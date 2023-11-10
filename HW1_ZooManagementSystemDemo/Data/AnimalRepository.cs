using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HW1_ZooManagementSystemDemo.Exceptions;
using HW1_ZooManagementSystemDemo.Models;

namespace HW1_ZooManagementSystemDemo.Data;

public class AnimalRepository : IAnimalRepository
{

    private readonly List<Models.Animal> _animalData;

    public AnimalRepository()
    {

        // Seed Data
        //keeperid=-1 means no keeper
        _animalData = new List<Animal>()
        {
            new Animal{Id=1, Name="Animal1", Kind="Penguin", Age=5, AtZooSince= new DateTime(2018, 1, 1), KeeperId=1},
            new Animal{Id=2, Name="Animal2", Kind="Penguin", Age=2, AtZooSince= new DateTime(2021, 1, 1), KeeperId=1},
            new Animal{Id=3, Name="Animal3", Kind="Parrot", Age=40, AtZooSince= new DateTime(2010, 6, 1), KeeperId=2},
            new Animal{Id=4, Name="Animal4", Kind="Giraffe", Age=12, AtZooSince= new DateTime(2011, 4, 10), KeeperId=4}
        };
    }

    public void Add(Animal animal)
    {
        int idAnimal = animal.Id;
        int index = _animalData.FindIndex(animal => animal.Id == idAnimal);

        if (index != -1)
        {
            throw new AnimalAlreadyExistsException(idAnimal);
        }
        _animalData.Add(animal);
    }

    public void Delete(int id)
    {
        Animal? animal = _animalData.Where(x => x.Id == id).SingleOrDefault();
        if (animal == null)
        {
            throw new AnimalNotFoundException(id);
        }
        _animalData.Remove(animal);
    }

    public void Update(Animal animal)
    {

        int idAnimal = animal.Id;
        int index = _animalData.FindIndex(animal => animal.Id == idAnimal);

        if (index == -1)
        {
            throw new AnimalNotFoundException(idAnimal);
        }

        _animalData[index] = animal;
    }

    public List<Animal> GetAll()
    {
        return _animalData;
    }

    public Animal? GetById(int id)
    {
        Animal? animal = _animalData.SingleOrDefault(x => x.Id == id);

        if (animal == null)
        {
            throw new AnimalNotFoundException(id);
        }
        return animal;
    }

    public List<Animal> GetByKind(string kind)
    {
        List<Animal> matchingAnimals = _animalData.Where(x => x.Kind == kind).ToList();

        if (matchingAnimals.Count == 0)
        {
            throw new AnimalNotFoundWithKindException(kind);
        }
        return matchingAnimals;
    }

    public List<Animal> GetByKeeperId(int keeperId)
    {
        List<Animal> matchingAnimals = _animalData.Where(x => x.KeeperId == keeperId).ToList();

        if (matchingAnimals.Count == 0)
        {
            throw new AnimalNotFoundWithKeeperException(keeperId);
        }
        return matchingAnimals;
    }

    public List<Animal> GetByName(string name)
    {
        List<Animal> matchingAnimals = _animalData.Where(x => x.Name == name).ToList();

        if (matchingAnimals.Count == 0)
        {
            throw new AnimalNotFoundWithNameException(name);
        }
        return matchingAnimals;
    }
}
