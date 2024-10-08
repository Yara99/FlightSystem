using FlightSystem.Core.Common;
using FlightSystem.Core.Repository;
using FlightSystem.Core.Services;
using FlightSystem.Infra.Common;
using FlightSystem.Infra.Repository;
using FlightSystem.Infra.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDbContext, DbContext>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IAirportRepository, AirportRepository>();
builder.Services.AddScoped<IAirportService, AirportService>();

builder.Services.AddScoped<IFlightRepository, FlightRepository>();
builder.Services.AddScoped<IFlightService, FlightService>();

builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<ITestimonialRepository, TestimonialRepository>();

builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<ICountryService, CountryService>();

builder.Services.AddScoped<IPartnerRepository, PartnerRepository>();
builder.Services.AddScoped<IPartnerService, PartnerService>();

builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
builder.Services.AddScoped<IReservationService, ReservationService>();


builder.Services.AddScoped<IDegreeRepository, DegreeRepository>();
builder.Services.AddScoped<IDegreeService, DegreeService>();

builder.Services.AddScoped<IFacilityRepository, FacilityRepository>();
builder.Services.AddScoped<IFacilityService, FacilityService>();

builder.Services.AddScoped<IDegreeFacilityRepository, DegreeFacilityRepository>();
builder.Services.AddScoped<IDegreeFacilityService, DegreeFacilityService>();

builder.Services.AddScoped<IAirlineRepository, AirlineRepository>();
builder.Services.AddScoped<IAirlineService, AirlineService>();

builder.Services.AddScoped<ICityRepository,CityRepository >();
builder.Services.AddScoped<ICityService, CityService>();

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
