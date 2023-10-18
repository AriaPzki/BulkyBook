//MODEL : Represents the shape of the data
//VIEW : Represents the user interface
//CONTROLLER : Handles the user request and acts as a interface between Model and View
//1-Request 2-Get Data 3-Get Presentation 4-Response
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


// This is all the middlewares we are using thru pipline
// The order of this middlewares matters
// ex : you should use app.UseAuthentication() before app.UseAuthorization()
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Routing
// If nothing is presented in URL, the default is declared as below
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
