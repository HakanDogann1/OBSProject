using Microsoft.EntityFrameworkCore;
using OBSProject.BusinessLayer.Abstract;
using OBSProject.BusinessLayer.Concrete;
using OBSProject.DataAccessLayer.Abstract;
using OBSProject.DataAccessLayer.Concrete;
using OBSProject.DataAccessLayer.Context;
using OBSProject.DataAccessLayer.EntityFramework;
using OBSProject.EntityLayer.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<OBSProjectDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlCon"));
});

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<OBSProjectDbContext>();

builder.Services.AddScoped<IAttendanceService, AttendanceManager>();
builder.Services.AddScoped<IAttendanceDal, EfAttendanceDal>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
