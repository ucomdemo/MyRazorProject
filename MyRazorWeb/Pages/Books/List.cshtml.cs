using Microsoft.AspNetCore.Mvc.RazorPages;
using MyModels;
using MyServices;

namespace MyRazorWeb.Pages.Books {
  public class ListModel(IBookRepository bookRepository) : PageModel {
    public IEnumerable<Book> Books { get; set; } = null!;
    public void OnGet() {
      //var x = 0;
      //var y = 10 / x;

      Books = bookRepository.GetAllBooks();
    }
  }
}
