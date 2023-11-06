using HW1_BookProjectModified.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_BookProjectModified.Business;

internal interface IAuthorService
{
    void GetList();
    void Add(Author author);
    void Delete(int id);
    void GetById(int id);
}
