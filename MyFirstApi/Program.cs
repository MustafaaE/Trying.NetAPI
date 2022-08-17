using Microsoft.EntityFrameworkCore;
using MyFirstApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// the supress surpasses through errors and still creates a POST request 
//even if required fields are empty 
builder.Services.AddControllers();

// the supress surpasses through errors and still creates a POST request 
//even if required fields are empty 
//.ConfigureApiBehaviorOptions(options =>
//{
//    options.SuppressModelStateInvalidFilter = true;
//});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ShopContext>(options =>
{
    options.UseInMemoryDatabase("Shop");
});

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
