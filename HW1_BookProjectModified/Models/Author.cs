using HW1_BookProjectModified.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_BookProjectModified.Models;

public class Author :EntityBase<int>
{
    public string Name { get; set; }


    public override string ToString()
    {
        return $"Id : {Id}, Name : {Name}";
    }
}

