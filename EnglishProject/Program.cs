using EnglishProject.Services.Projects.ApiWeather;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddHttpClient<ApiWeatherService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=HomePage}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(
        name: "projects",
        pattern: "{controller=ApiWeather}/{action=GetWeather}")
    .WithStaticAssets();

app.MapControllerRoute(
        name: "projects",
        pattern: "{controller=WeatherGame}/{action=WeatherGame}")
    .WithStaticAssets();

app.Run();