
using DataAccess.DbAccess;
using MinimumAPIDemo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// dependency inject 
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>(); // need to inject with isqldataaccess
builder.Services.AddSingleton<IUserData, UserData>(); // talk to data

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.ConfigureApi();

app.Run();
