using BMSClone.Context;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<DataContext>(options => { options.UseSqlServer("Server=SURUKK;Database=BMSClone;Trusted_Connection=True;TrustServerCertificate=True"); });
builder.Services.AddScoped<DbContext, DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    dbContext.Database.EnsureCreated();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
