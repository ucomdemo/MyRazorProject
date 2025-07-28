using MyRazorWeb.Services;
using MyServices;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddTransient<IMathService, MathService>();
builder.Services.AddSingleton<IBookRepository, BookRepository>();

builder.Services.Configure<RouteOptions>(options => {
  options.LowercaseUrls = true;
});

var app = builder.Build();

if (!app.Environment.IsDevelopment()) {
  app.UseExceptionHandler("/Error");
  //app.UseHsts();
}

app.UseStatusCodePages("text/html; charset=utf-8", "<h3>µo¥Í¿ù»~,Status Code:{0}</h3>");

//app.UseHttpsRedirection();
app.UseRouting();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
