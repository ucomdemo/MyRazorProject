using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyModels;
using MyServices;

namespace MyRazorWeb.Pages.Books {
  public class DeleteModel( IBookRepository bookRepository ) : PageModel {
    [BindProperty]
    public Book Book { get; set; } = null!;
    public IActionResult OnGet( int id ) {
      Book = bookRepository.GetBook( id );
      if ( Book.Id != id ) {
        return RedirectToPage( "/NotFound" );
      }
      return Page( );
    }
    public IActionResult OnPost() {
      if (Book == null || Book.Id <= 0) {
        return RedirectToPage("/NotFound");
      }

      try {
        bookRepository.Delete(Book.Id);
      }
      catch (Exception) {
        return RedirectToPage("/NotFound");
      }
      return RedirectToPage("List");
    }
  }
}
