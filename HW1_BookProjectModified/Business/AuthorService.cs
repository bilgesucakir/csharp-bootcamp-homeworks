using HW1_BookProjectModified.Data;
using HW1_BookProjectModified.Models;
using HW1_BookProjectModified.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_BookProjectModified.Business;

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public void Add(Author author)
    {
        try
        {
            AddAuthorRule(author);

            _authorRepository.Add(author);

            GetList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _authorRepository.Delete(id);
            GetList();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(int id)
    {
        try{
            Author? author = _authorRepository.GetById(id);
            Console.WriteLine(author);
        }
        catch(AuthorNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetList()
    {
        List<Author> authors = _authorRepository.GetAll();
        authors.ForEach(author => Console.WriteLine(author));
    }


    private void AddAuthorRule(Author author)
    {
        if (author.Name.Length < 2)
        {
            throw new AuthorNameException(author.Name);
        }
    }
}


