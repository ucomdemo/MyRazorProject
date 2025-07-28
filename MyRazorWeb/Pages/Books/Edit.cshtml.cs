using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyModels;
using MyServices;

namespace MyRazorWeb.Pages.Books {
  public class EditModel(IBookRepository bookRepository) : PageModel {
    [BindProperty]
    public Book Book { get; set; } = null!;
    public IActionResult OnGet(int id) {
      Book = bookRepository.GetBook(id);
      if (Book.Id != id) {
        return RedirectToPage("/NotFound");
      }
      return Page();
    }
    public IActionResult OnPost() {
      if (!ModelState.IsValid) {
        return Page();
      }
      Book? updatedBook = bookRepository.Update(Book);
      if (updatedBook == null) {
        ModelState.AddModelError(string.Empty, "Unable to update the book.");
        return Page();
      }
      Book = updatedBook;
      return RedirectToPage("List");
    }

  }
}

