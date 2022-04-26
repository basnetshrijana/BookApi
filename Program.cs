using Microsoft.EntityFrameworkCore;
using BookApi.Data;
using FluentValidation.AspNetCore;
using BookApi.Models.RequestModel;
using BookApi.Validator;
using FluentValidation;
using BookApi.Services.Implementation;
using BookApi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddFluentValidation();
builder.Services.AddTransient<IValidator<BookRequestModel>, BookValidator>();
builder.Services.AddTransient<IValidator<ProductRequestModel>, ProductValidator>();
builder.Services.AddTransient<IBookServices , BookServices>();
builder.Services.AddTransient<IProductServices, ProductServices>();
builder.Services.AddTransient<IBookRepository, BookRepository>();
builder.Services.AddTransient<IProductRepository,ProductRepository>();
builder.Services.AddTransient<IUnitofWork, UnitofWork>();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
