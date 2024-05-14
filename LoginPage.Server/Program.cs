using LoginPage.EF;
using Microsoft.Extensions.Configuration;
using System.Net;
using LoginPage.Business;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddDbContext<AppDbContext>(options =>
//          options(Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<AuthenticationEFDataManager, AuthenticationEFDataManager>();
builder.Services.AddScoped<LoginPage.Business.AuthenticationManager, LoginPage.Business.AuthenticationManager>();  

var app = builder.Build();
app.UseCors("corsapp");

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseRouting();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
