using BMSClone.Context;
using BMSClone.services;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);


var jwtIssuer = builder.Configuration.GetSection("Jwt:Issuer").Get<string>();
var jwtkey = builder.Configuration.GetSection("Jwt:Key").Get<string>();

// Add services to the container.

builder.Services.AddAuthentication().AddOAuth("github", o => { o.ClientId = "fa1729c8f2b1faddb172";
    o.ClientSecret = "3de87ff8f82eb15d7abf0dfc386ca9eef8c68b46";
    o.AuthorizationEndpoint = "https://github.com/login/oauth/authorize";
    o.TokenEndpoint = "https://github.com/login/oauth/access_token";

    o.UserInformationEndpoint = "https://api.github.com/user";



});

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
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//using (var scope = app.Services.CreateScope())
//{
//    var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
//    dbContext.Database.Migrate();
//    dbContext.Database.EnsureCreated();
//}


app.UseHttpsRedirection();
app.UseCors("AllowAllOrigins");

//app.UseAuthorization();

app.MapControllers();

app.Run();
