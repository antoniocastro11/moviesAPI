using Microsoft.EntityFrameworkCore;
using moviesApi.Data;
using moviesApi.Profiles;

var builder = WebApplication.CreateBuilder(args);
var connString  = builder.Configuration.GetConnectionString("DatabaseConnection");

builder.Services.AddDbContext<MovieContext>(opts => opts.UseNpgsql(connString));
// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddAutoMapper(
    cfg => { },
    typeof(CinemaProfile),
    typeof(AddressProfile),
    typeof(MovieProfile),
    typeof(SessionProfile)
);
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
