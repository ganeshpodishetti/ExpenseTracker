using ExpenseTracker.Core.DBModels;
using ExpenseTracker.Data;
using ExpenseTracker.Service;
using ExpenseTracker.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Two parts.
// 1. Service Configuration
// 2. Middleware Configuration

// 1. Service Configuration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddServices();
// Db Connection
// connection string
var connectionString = configuration.GetConnectionString("ExpenseTracker");
builder.Services.AddDbContext<ExpenseTrackerDbContext>(options => options.UseSqlServer(connectionString)
.EnableSensitiveDataLogging(true)); // only for development purpose, should not be used in Prod

// 2. From here, It is related to the middleware configuration
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.Run();

