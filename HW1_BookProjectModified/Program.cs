// Kitap ekleme listeleme ve silme gibi operasyonları simüle edeceğiz
// veri tabanı gibi çalışan bir liste kullanacağız

using HW1_BookProjectModified.Business;
using HW1_BookProjectModified.Data;
using HW1_BookProjectModified.Models;
// Dapper


IBookService bookService = new BookService(new BookRepository());
IAuthorService authorService = new AuthorService(new AuthorRepository());
//bookService.GetList();

/*Book book = new Book()
{
    Id = 5,
    Description = "Test",
    Price=2500,
    Stock=-2000,
    Title= "Test"
};*/

//Console.WriteLine("Kayıt ekleme : ");
//bookService.Add(book);
//Console.WriteLine("Kayıt silme : ");
//bookService.Delete(2);

//Console.WriteLine("Id ye göre getirme:");
//bookService.GetById(2);


//Console.WriteLine("Kitapların listesi");
//bookService.GetList();

Console.WriteLine("new methods added to the project:");

Console.WriteLine("\nget books list (authorid will be shown too)");
bookService.GetList();

Console.WriteLine("\nget book with isbn (book with isbn exists example)");
bookService.GetByIsbn("012-3-45-678901-2");

Console.WriteLine("\nget book with isbn (book with isbn does not exist example)");
bookService.GetByIsbn("012-3-45-678901-9");

Console.WriteLine("\nget author by id (exists)");
authorService.GetById(1);

Console.WriteLine("\nget author by id (does not exist)");
authorService.GetById(111);

Console.WriteLine("\nget authors list");
authorService.GetList();

Console.WriteLine("\nadd author (correct name format)");
Author author = new Author()
{
    Id = 4,
    Name = "Author4"

};
authorService.Add(author);

Console.WriteLine("\nadd author (wrong name format)");
Author authorTwo = new Author()
{
    Id = 4,
    Name = "a"

}; ;
authorService.Add(authorTwo);

Console.WriteLine("\ndelete author (existing author)");
authorService.Delete(4);

Console.WriteLine("\ndelete author (non existing author)");
authorService.Delete(999);




