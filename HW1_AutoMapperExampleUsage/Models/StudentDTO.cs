using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_AutoMapperExampleUsage.Models
{
    public class StudentDTO
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"StudentId: {StudentId}, Name: {Name}, LastName: {LastName}, Age: {Age}";
        }
    }
}
