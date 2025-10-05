using EFProject.Data;
using EFProject.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Configuração do DbContext com SQLite
var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "EntidadeReserva.db");
Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);

builder.Services.AddDbContext<EntidadeReservaContext>(options =>
    options.UseSqlite($"Data Source={dbPath}"));

// Serviço como Scoped
builder.Services.AddScoped<PacoteTuristicoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();

// INICIALIZAÇÃO DO BANCO COM DATAS DINÂMICAS
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<EntidadeReservaContext>();

        // Criar banco e estruturas básicas
        var created = context.Database.EnsureCreated();

        Console.WriteLine(created ?
            "✅ Banco de dados criado com sucesso!" :
            "✅ Banco de dados já existe.");

        // Inicializar com datas dinâmicas
        DbInitializer.Initialize(context);

        Console.WriteLine($"📍 Localização: {dbPath}");
        Console.WriteLine($"🕒 Datas configuradas dinamicamente!");

        // Verificar dados
        var clientesCount = context.Clientes.Count();
        var pacotesCount = context.PacotesTuristicos.Count();
        var reservasCount = context.Reservas.Count();

        Console.WriteLine($"📊 Dados: {clientesCount} clientes, {pacotesCount} pacotes, {reservasCount} reservas");

        // Mostrar datas de criação
        var clienteMaisRecente = context.Clientes.OrderByDescending(c => c.DataCriacao).First();
        Console.WriteLine($"📅 Cliente mais recente criado em: {clienteMaisRecente.DataCriacao}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"❌ Erro ao criar banco: {ex.Message}");
    }
}

app.Run();