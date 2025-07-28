using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazorWeb.Services;

namespace MyRazorWeb.Pages {
  public class CalcModel(IMathService mathService) : PageModel {
    public int Result { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public void OnGetAsync() {
      _ = int.TryParse(Request.Query["x"], out int x);
      _ = int.TryParse(Request.Query["y"], out int y);
      X = x;
      Y = y;
      Result = mathService.Add(x, y);
      mathService.Count++;
    }
  }
}

