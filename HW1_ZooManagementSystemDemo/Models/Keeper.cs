﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Models;

public class Keeper :EntityBase<int>
{
    public string Name { get; set; }

    public int Age { get; set; }

    public string Gender { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Age: {Age}, Gender: {Gender}";
    }

}
