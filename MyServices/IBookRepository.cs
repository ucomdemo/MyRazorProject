using MyModels;

namespace MyServices {
  public interface IBookRepository {
    IEnumerable<Book> GetAllBooks();
    Book GetBook(int id);
    Book? Update(Book editBook);
   Book Create( Book newBook );
    Book Delete(int id);
    //IEnumerable<CategoryCount> GetBookCountByCategory();
    //IEnumerable<Book> GetBookByKeyword( string keyword );
  }
}







