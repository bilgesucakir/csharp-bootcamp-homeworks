using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_ZooManagementSystemDemo.Models;

public class Animal :EntityBase<int>
{
    public string Name { get; set; }
    public string Kind { get; set; }
    public int Age { get; set; }

    public DateTime AtZooSince { get; set; }

    public int? KeeperId { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Kind: {Kind}, Age: {Age}, AtZooSince: {AtZooSince.Year}/{AtZooSince.Month}/{AtZooSince.Day}, KeeperId: {KeeperId}";
    }
}
