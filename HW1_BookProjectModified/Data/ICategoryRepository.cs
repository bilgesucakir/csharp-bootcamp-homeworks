using HW1_BookProjectModified.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_BookProjectModified.Data;

public interface ICategoryRepository : IEntityBaseRepository<Category,string>
{

}

