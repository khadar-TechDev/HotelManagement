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


var app = builder.Build();

//Configuring cors policy here to match the origin to any as of now , may change it later


// Configure the HTTP request pipeline.
app.UseStaticFiles();
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAnyOrigin");
app.UseAuthorization();
app.MapControllers();
app.Run();
