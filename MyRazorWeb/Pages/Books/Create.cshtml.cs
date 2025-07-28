using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyModels;
using MyServices;

namespace MyRazorWeb.Pages.Books {
  public class CreateModel(IBookRepository bookRepository) : PageModel {
    [BindProperty]
    public Book Book { get; set; } = null!;

    [Required(ErrorMessage = "�ϮѦW�٤��i���ť�")]
    [MaxLength(50, ErrorMessage = "���פ��i�W�L {1}")]
    [BindProperty, PageRemote(
      ErrorMessage = "�w�s�b���ƪ��ϮѦW��",
      AdditionalFields = "__RequestVerificationToken",
      HttpMethod = "post",
      PageHandler = "CheckTitle"
      )]
    public string Title { get; set; } = null!;
    public JsonResult OnPostCheckTitle() {
      var valid = !(bookRepository.GetAllBooks()?.Count(b => b.Title == Title) > 0);
      return new JsonResult(valid);
    }

    public IActionResult OnGet() {
      return Page();
    }
    public IActionResult OnPost() {
      if (!ModelState.IsValid) {
        return Page();
      }
      try {
        Book.Title = Title;
        bookRepository.Create(Book);
      }
      catch (Exception ex) {
        ModelState.AddModelError(string.Empty, $"�s�W���� : {ex.Message}");
        return Page();
      }
      return RedirectToPage("List");
    }
  }
}
