using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorWeb.Pages {
  public class ErrorModel : PageModel {
    public string? ExceptionMessage { get; set; }
    public void OnGet() {
      var feature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
      var err = feature?.Error;
      ExceptionMessage = $" Message : {err?.Message} Path : {feature?.Path}";
    }
  }
}
