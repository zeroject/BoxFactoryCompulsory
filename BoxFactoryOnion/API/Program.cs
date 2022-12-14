using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());

var mapper = new MapperConfiguration(config =>
{
    config.CreateMap<GetBoxDTO, Box>();
    config.CreateMap<GetCustomerDTO, Customer>();
    config.CreateMap<GetOrderDTO, Order>();
}).CreateMapper();

builder.Services.AddSingleton(mapper);

Infrastructure.DependencyResolver.DependencyResolverService.RegisterInfrastructureLayer(builder.Services);
Application.DependencyResolver.DependencyResolverService.RegisterApplicationLayer(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(a =>
{
    a.AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
