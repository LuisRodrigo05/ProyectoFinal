using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Client.Pages;
using ProyectoFinal.Components;
using ProyectoFinal.Modelo;
using ProyectoFinal.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ConsultorioDBContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConection")));
builder.Services.AddScoped<IRepositorioClientes, RepositorioClientes>();
builder.Services.AddScoped<IRepositorioCitas, RepositorioCitas>();
builder.Services.AddScoped<IRepositorioTerapeutas, RepositorioTerapeutas>();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

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
    .AddAdditionalAssemblies(typeof(ProyectoFinal.Client._Imports).Assembly);

app.Run();
