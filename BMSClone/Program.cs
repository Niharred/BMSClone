using BMSClone.Context;
using BMSClone.services;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);


var jwtIssuer = builder.Configuration.GetSection("Jwt:Issuer").Get<string>();
var jwtkey = builder.Configuration.GetSection("Jwt:Key").Get<string>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.Services.AddDbContext<DataContext>(options => { options.UseSqlServer("Server=SURUKK;Database=BMSClone;Trusted_Connection=True;TrustServerCertificate=True"); });
builder.Services.AddScoped<DbContext, DataContext>();
builder.Services.AddScoped<IDataservice, DataService>();

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
