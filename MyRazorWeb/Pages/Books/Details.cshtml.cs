using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyModels;
using MyServices;

namespace MyRazorWeb.Pages.Books {
  public class DetailsModel( IBookRepository bookRepository ) : PageModel {
    public Book Book { get; private set; } = null!;
    public IActionResult OnGet(int id) {
      Book = bookRepository.GetBook(id);
      if (Book.Id != id) {
        return RedirectToPage("/NotFound");
      }
      return Page();
    }

  }
}
