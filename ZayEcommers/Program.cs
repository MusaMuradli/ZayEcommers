using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using ZayEcommers.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();

app.UseEndpoints(endpoints => endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}"));


app.Run();
