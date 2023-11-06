
namespace HW1_BookProjectModified.Models;

public class Category :EntityBase<string>
{
    public string Name { get; set; }


    public override string ToString()
    {
        return $"Id : {Id}, Name : {Name}";
    }
}
