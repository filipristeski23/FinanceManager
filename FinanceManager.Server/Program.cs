using FinanceManager.Server.Application;
using FinanceManager.Server.Data;
using FinanceManager.Server.Repositories.Implementations;
using FinanceManager.Server.Repositories.Interfaces;
using FinanceManager.Server.Services.Implementations;
using FinanceManager.Server.Services.Interfaces;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IEachPurchaseService, EachPurchaseService>();
builder.Services.AddScoped<IEachPurchase, EachPurchaseImplementation>();
builder.Services.AddControllers();









var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
