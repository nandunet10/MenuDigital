using Menu.Repositories.Implementations;
using Menu.Repositories.Interfaces;
using Menu.Services;

var builder = WebApplication.CreateBuilder(args);

// Registro de serviços
builder.Services.AddScoped<IMenuRepository, MenuRepository>();
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();

builder.Services.AddScoped<MenuService>();
builder.Services.AddScoped<PedidoService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
