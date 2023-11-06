using HW1_BookProjectModified.Exceptions;
using HW1_BookProjectModified.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW1_BookProjectModified.Data;

public class AuthorRepository : IAuthorRepository
{

    private readonly List<Author> _authorData;

    public AuthorRepository()
    {

        // Seed Data
        _authorData = new List<Author>()
        {
              new Author{Id=1, Name="Author1"},
              new Author{Id=2, Name="Author2"},
              new Author{Id=3, Name="Author3"}
        };
    }

    public void Add(Author author)
    {
        _authorData.Add(author);
    }

    public void Delete(int id)
    {
        Author? author = _authorData.Where(x => x.Id == id).SingleOrDefault();
        if (author is null)
        {
            throw new AuthorNotFoundException(id);
        }
        _authorData.Remove(author);
    }

    public List<Author> GetAll()
    {
        return _authorData;
    }

    public Author? GetById(int id)
    {
        Author? author = _authorData.SingleOrDefault(x => x.Id == id);

        if (author == null)
        {
            throw new AuthorNotFoundException(id);
        }
        return author;
    }


}
