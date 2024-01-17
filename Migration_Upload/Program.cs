using Context.Capmas_Test;
using Context.Old_Models;
using IServices_Repository_Layer;
using Microsoft.EntityFrameworkCore;
using Services_Repository_Layer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddControllers();
builder.Services.AddDbContext<NewCapmasWebsiteContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
   b => b.MigrationsAssembly(typeof(NewCapmasWebsiteContext).Assembly.FullName)));

builder.Services.AddDbContext<CapmasTestContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("CampasDb"),
   b => b.MigrationsAssembly(typeof(CapmasTestContext).Assembly.FullName)));


#region DI
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<IOLDNewsRepo, OLDNewsRepo>();
builder.Services.AddTransient<INew_News_Repo, New_News_Repo>();
builder.Services.AddTransient<IHistory_Details_Repo, History_Details_Repo>();


#endregion
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
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
