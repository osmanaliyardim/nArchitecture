<<<<<<< Updated upstream:src/demoProjects/templateProject/WebAPI/Program.cs
using Application;
using Core.CrossCuttingConcerns.Exceptions;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Contexts;
=======
﻿using Application;
using Core.CrossCuttingConcerns.Exceptions;
using Persistance;
>>>>>>> Stashed changes:src/demoProjects/rentACar/WebAPI/Program.cs

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices();
<<<<<<< Updated upstream:src/demoProjects/templateProject/WebAPI/Program.cs
builder.Services.AddSecurityServices();
=======
>>>>>>> Stashed changes:src/demoProjects/rentACar/WebAPI/Program.cs
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddInfrastructureServices();
builder.Services.AddHttpContextAccessor();



builder.Services.AddControllers();
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

if (app.Environment.IsProduction())
<<<<<<< Updated upstream:src/demoProjects/templateProject/WebAPI/Program.cs
    app.ConfigureCustomExceptionMiddleware();
=======
{
    app.ConfigureCustomExceptionMiddleware();
}
>>>>>>> Stashed changes:src/demoProjects/rentACar/WebAPI/Program.cs

app.UseAuthorization();

app.MapControllers();

<<<<<<< Updated upstream:src/demoProjects/templateProject/WebAPI/Program.cs
app.Run();
=======
app.Run();
>>>>>>> Stashed changes:src/demoProjects/rentACar/WebAPI/Program.cs
