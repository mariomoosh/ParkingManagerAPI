using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ParkingManager.DataLayer.Core.Mapper.Profiles;
using ParkingManager.DataLayer.DataAccess;
using ParkingManager.DataLayer.Services;

AutoMapper.IConfigurationProvider mapperConfig = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<ParkingLotProfile>();
    cfg.AddProfile<ParkingSpotProfile>();
});

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ParkingManagerDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:ParkingManagementStr"]);
});
builder.Services.AddSingleton(mapperConfig);
builder.Services.AddScoped<IMapper, Mapper>();
builder.Services.AddScoped<ParkingLotsServices>();
builder.Services.AddScoped<ParkingSpotsServices>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("_allAccepted", builder => {
        builder.AllowAnyOrigin();
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("_allAccepted");

app.UseAuthorization();

app.MapControllers();

app.Run();
