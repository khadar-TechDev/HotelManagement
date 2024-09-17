using HotelManagement.Server.Repository.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin", configure =>
    {
        configure.AllowAnyOrigin();
        configure.AllowAnyMethod();
        configure.AllowAnyHeader();
    });
});

builder.Services.AddDbContext<HotelManagementDBContext>(options =>
{
    options.UseSqlite("Data Source=C:\\Users\\KK016874\\OneDrive - Zelis Healthcare\\Documents\\Projects\\HotelManagement\\HotelManagement.Server\\HotelManagement.Server.Repository\\SQlite File\\HotelManagementDB.db");
});

var app = builder.Build();



// Configure the HTTP request pipeline.
app.UseStaticFiles();
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Configuring cors policy here to match the origin to any as of now , may change it later
app.UseCors("AllowAnyOrigin");

app.UseAuthorization();
app.MapControllers();
app.Run();
