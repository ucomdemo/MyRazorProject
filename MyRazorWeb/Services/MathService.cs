namespace MyRazorWeb.Services {
 
  public class MathService : IMathService {
    public int Add( int x, int y ) => x + y;
    public int Count { get; set; }
  }
}
