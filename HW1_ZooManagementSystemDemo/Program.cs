// See https://aka.ms/new-console-template for more information
using HW1_ZooManagementSystemDemo.Business;
using HW1_ZooManagementSystemDemo.Data;
using HW1_ZooManagementSystemDemo.Models;

IAnimalRepository animalRepository = new AnimalRepository();
IKeeperRepository keeperRepository = new KeeperRepository();

IKeeperService keeperService = new KeeperService(keeperRepository, animalRepository);
IAnimalService animalService = new AnimalService(animalRepository, keeperRepository);


Console.WriteLine("Examples for Zoo Managaement System Demo");

/*animal*/
Console.WriteLine("\nget animals list");
animalService.GetList();

Console.WriteLine("\nget animal with existing id");
animalService.GetById(1);

Console.WriteLine("\nget animal with non-existing id");
animalService.GetById(8888);

Console.WriteLine("\nget animal with existing kind");
animalService.GetByKind("Penguin");

Console.WriteLine("\nget animal with non-existing kind");
animalService.GetByKind("Cheetah");

Console.WriteLine("\nget animal with existing keeper id");
animalService.GetByKeeperId(1);

Console.WriteLine("\nget animal with non-existing keeper id");
animalService.GetByKeeperId(200);

Console.WriteLine("\nget animal with existing name");
animalService.GetByName("Animal3");

Console.WriteLine("\nget animal with non-existing name");
animalService.GetByName("Dave");

Console.WriteLine("\nadd animal with correct keeper id, non-existing animal id");
Animal animal1 = new Animal
{
    Id = 5,
    Name = "Animal5",
    Kind = "Cat",
    Age = 3,
    AtZooSince = new DateTime(2022, 8, 12),
    KeeperId = 4
};
animalService.Add(animal1);

Console.WriteLine("\nadd animal with correct keeper id, existing animal id");
Animal animal2 = new Animal
{
    Id = 3,
    Name = "NewAnimal",
    Kind = "Snake",
    Age = 10,
    AtZooSince = new DateTime(2023, 8, 10),
    KeeperId = 3
};
animalService.Add(animal2);

Console.WriteLine("\nadd animal with empty keeper id");
Animal animal3 = new Animal
{
    Id = 6,
    Name = "Animal6",
    Kind = "Dog",
    Age = 2,
    AtZooSince = new DateTime(2023, 1, 12)
};
animalService.Add(animal3);

Console.WriteLine("\nadd animal with non-exsiting keeper id");
Animal animal4 = new Animal
{
    Id = 7,
    Name = "Animal7",
    Kind = "Crocodile",
    Age = 10,
    AtZooSince = new DateTime(2020, 10, 9),
    KeeperId = 99
};
animalService.Add(animal4);

Console.WriteLine("\nupdate animal (with existing keeper id, with existing id)");
Animal animal5 = new Animal
{
    Id = 5,
    Name = "Animal5-NewName",
    Kind = "Cat",
    Age = 3,
    AtZooSince = new DateTime(2022, 8, 12),
    KeeperId = 2
};
animalService.Update(animal5);

Console.WriteLine("\nupdate animal with existing keeper id, with non-existing id");
Animal animal6 = new Animal
{
    Id = 100,
    Name = "Animal5-NewName2",
    Kind = "Cat",
    Age = 3,
    AtZooSince = new DateTime(2022, 8, 12),
    KeeperId = 2
};
animalService.Update(animal6);

Console.WriteLine("\nupdate animal with empty keeper id");
Animal animal7 = new Animal
{
    Id = 5,
    Name = "Animal5NewName",
    Kind = "Cat",
    Age = 3,
    AtZooSince = new DateTime(2022, 8, 12)
};
animalService.Update(animal7);

Console.WriteLine("\nupdate animal with non-exsiting keeper id");
Animal animal8 = new Animal
{
    Id = 5,
    Name = "Animal5NewName",
    Kind = "Cat",
    Age = 3,
    AtZooSince = new DateTime(2022, 8, 12),
    KeeperId = 100
};
animalService.Update(animal8);

Console.WriteLine("\ndelete animal with existing id");
animalService.Delete(6);

Console.WriteLine("\ndelete animal with non-existing id");
animalService.Delete(1234);

/*keeper*/
Console.WriteLine("\nget keepers list");
keeperService.GetList();

Console.WriteLine("\nget keeper with existing id");
keeperService.GetById(2);

Console.WriteLine("\nget keeper with non-existing id");
keeperService.GetById(777);

Console.WriteLine("\nget keeper with existing name");
keeperService.GetByName("Keeper4");

Console.WriteLine("\nget keeper with non-existing name");
keeperService.GetByName("Sam");

Console.WriteLine("\nget keeper with existing animal id");
keeperService.GetByAnimalId(3);

Console.WriteLine("\nget keeper with non-existing animal id");
keeperService.GetByAnimalId(25);

Console.WriteLine("\nadd keeper with non-existing id");
Keeper keeper1 = new Keeper
{
    Id = 5,
    Name = "Keeper5",
    Age = 47,
    Gender = "Male"
};
keeperService.Add(keeper1);

Console.WriteLine("\nadd keeper with existing id");
Keeper keeper2 = new Keeper
{
    Id = 1,
    Name = "NewKeeper",
    Age = 40,
    Gender = "Male"
};
keeperService.Add(keeper2);

Console.WriteLine("\nupdate keeper with non-existing id");
Keeper keeper3 = new Keeper
{
    Id = 100,
    Name = "KeeperNewName",
    Age = 50,
    Gender = "Female"
};
keeperService.Update(keeper3);

Console.WriteLine("\nupdate keeper with existing id");
Keeper keeper4 = new Keeper
{
    Id = 3,
    Name = "Keeper3-Updated",
    Age = 32,
    Gender = "Female"
};
keeperService.Update(keeper4);

Console.WriteLine("\ndelete keeper with existing id (takes care of at least one animal)");
keeperService.Delete(4);

Console.WriteLine("\ndelete keeper with existing id (does not take care of an animal currently)");
keeperService.Delete(3);

Console.WriteLine("\ndelete keeper with non-existing id");
keeperService.Delete(1234);
