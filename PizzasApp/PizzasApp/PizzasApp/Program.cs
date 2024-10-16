using PizzasApp.Components;
using PizzasApp.Data;
using PizzasApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents(options => options.DetailedErrors = builder.Environment.IsDevelopment())
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddRazorPages();

// Services
builder.Services.AddSingleton<PizzaService>();
builder.Services.AddHttpClient();
builder.Services.AddSqlite<PizzaStoreContext>("Data Source=pizza.db");
builder.Services.AddScoped<PizzaSalesState>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(PizzasApp.Client._Imports).Assembly);

// Ambito dbcontext
var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope()) {
    var db = scope.ServiceProvider.GetRequiredService<PizzaStoreContext>();
    if (db.Database.EnsureCreated()) { 
        SeedData.Initialize(db);
    }
}

app.MapRazorPages();
app.MapBlazorHub(config =>
{
    config.CloseOnAuthenticationExpiration = true;
});
// app.MapFallbackToPage("/Error");
app.MapControllerRoute("default", "{controller=Home}/{action=index}/{id?}");

app.Run();
