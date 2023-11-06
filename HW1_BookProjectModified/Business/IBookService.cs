

using HW1_BookProjectModified.Models;

namespace HW1_BookProjectModified.Business;

internal interface IBookService
{
    void GetList();
    void Add(Book book);
    void Delete(int id);
    void GetById(int id);

    void GetByIsbn(string isbn);
}
