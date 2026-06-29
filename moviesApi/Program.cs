using Microsoft.EntityFrameworkCore;
using moviesApi.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString  = builder.Configuration.GetConnectionString("MovieConnection");

builder.Services.AddDbContext<MovieContext>(opts => opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
// Add services to the container.

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
