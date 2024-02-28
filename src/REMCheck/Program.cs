using Core.Entities;
using Core.Queries;
using DAL;
using DAL.Queries.GetAllEvaluations;
using DAL.Queries.GetAllMistakes;
using DAL.Queries.GetAllReports;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<REMContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionStrings")));

builder.Services.AddScoped<IQueryHandler<GetAllReportsQuery, IList<Report>>, GetAllReportsQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetAllEvaluationsQuery, IList<Evaluation>>, GetAllEvaluationsQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetAllMistakesQuery, IList<Mistake>>, GetAllMistakesQueryHandler>();

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
