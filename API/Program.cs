using API;
using API.Data;
using API.Extensions;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// // builder.Services.AddDbContext<DataContext>(opt =>
// // {
// //     opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
// // });
// builder.Services.AddCors();
// // builder.Services.AddScoped<ITokenService, TokenService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(builder =>
    builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200")
);

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
