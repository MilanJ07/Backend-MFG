using BusinessLogicLayer.Implementations;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer.DataEntities;
using DataAccessLayer.Implementations;
using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddControllers();
builder.Services.AddDbContext<ModelContext>(options =>
options.UseOracle(builder.Configuration.GetConnectionString("Oracle")));
builder.Services.AddScoped<IPlantMasterRepository, PlantMasterRepository>();
builder.Services.AddScoped<IPlantMasterService, PlantMasterService>();
builder.Services.AddAutoMapper(typeof(DataAccessLayer.Profiles.MappingProfile));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
