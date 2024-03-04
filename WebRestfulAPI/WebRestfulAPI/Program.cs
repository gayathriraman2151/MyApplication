using Microsoft.EntityFrameworkCore;
using WebRestfulAPI.Model;
using WebRestfulAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ArticleApiContext>(opt => opt.UseInMemoryDatabase("ArticleDb"));

builder.Services.AddControllers();
builder.Services.AddScoped<IRepository, Repository>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
