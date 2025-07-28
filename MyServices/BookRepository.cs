using MyModels;
namespace MyServices {
  public class BookRepository : IBookRepository {
    private readonly List<Book> _books;
    public BookRepository() {
      _books = new List<Book>() {
         new Book() {
           Id = 1 ,
           Title = "Essential Programming Language" ,
           Price = 250 ,
           PublishDate = new DateTime( 2022 ,1,2 ) ,
           InStock = true ,
           Description = " Essential Programming Language "  ,
          Category = Category.Computers
         },
         new Book() {
           Id = 2 ,
           Title = "Telling Arts" ,
           Price = 245 ,
           PublishDate = new DateTime( 2022 , 4 , 15 ) ,
           InStock = true ,
           Description = " Telling Arts "  ,
          Category = Category.Arts
         },
           new Book() {
           Id = 3 ,
           Title = "Marvel" ,
           Price = 150  ,
           PublishDate = new DateTime( 2022 , 2, 21 ) ,
           InStock = true ,
           Description = " Marvel "  ,
          Category = Category.Commics
         },
          new Book() {
           Id = 4 ,
           Title = "The Beauty of Cook" ,
           Price = 450 ,
           PublishDate = new DateTime( 2022 ,12, 2 ) ,
           InStock = true ,
           Description = " The Beauty of Cook "  ,
           Category = Category.Cooking
         }
      };
    }
    public IEnumerable<Book> GetAllBooks() {
      return _books;
    }

    public Book GetBook(int id) {
      return _books.FirstOrDefault(b => b.Id == id) ?? new Book();
    }

    public Book? Update(Book editBook) {
      //return null;
      Book? book = _books.FirstOrDefault(b => b.Id == editBook.Id);
      if (book != null) {
        book.Title = editBook.Title;
        book.Price = editBook.Price;
        book.PublishDate = editBook.PublishDate;
        book.InStock = editBook.InStock;
        book.Description = editBook.Description;
        book.Category = editBook.Category;
      }
      return book;
    }
    public Book Create(Book newBook) {
      //throw new NotImplementedException();
      if (_books.Count == 0) {
        newBook.Id = 1;
      }
      else {
        newBook.Id = _books.Max(b => b.Id) + 1;
      }
      _books.Add(newBook);
      return newBook;
    }



    public Book Delete(int id) {
      Book book = _books.First(b => b.Id == id);
      _books.Remove(book);
      return book;
    }

    //public IEnumerable<CategoryCount> GetBookCountByCategory() {
    //  return _books
    //              .GroupBy(b => b.Category)
    //              .Select(g => new CategoryCount() {
    //                Category = g.Key!.Value,
    //                Count = g.Count()
    //              }).ToList();

    //}

    //public IEnumerable<Book> GetBookByKeyword( string keyword ) {
    //  return _books
    //      .Where( b => b.Title.Contains( keyword ) )
    //      .ToList();
    //}

  }

}
