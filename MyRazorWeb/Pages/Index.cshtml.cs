using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorWeb.Pages {
  public class IndexModel : PageModel {
    public string? Greeting { get; set; }
    public void OnGet() {
      Greeting = " Hello World ! ";
    }
  }
}
