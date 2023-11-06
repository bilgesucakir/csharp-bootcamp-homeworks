
using HW1_BookProjectModified.Models;

namespace HW1_BookProjectModified.Data;

public interface IBookRepository : IEntityBaseRepository<Book,int>
{
    public Book? GetByIsbn(string isbn);
}
