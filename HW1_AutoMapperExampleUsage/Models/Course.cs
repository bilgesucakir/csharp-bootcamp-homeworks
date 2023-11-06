using AutoMapper.Internal.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_AutoMapperExampleUsage.Models;

public class Course
{

    public int Id { get; set; }

    public string Name { get; set; }

    public string CourseCode { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, CourseCode: {CourseCode}";
    }


}
