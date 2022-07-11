
using HS.Domain.Core.Contracts.Repository;
using HS.Infrastructures.Database.Repos.Ef.AutoMapper;
using HS.Infrastructures.Database.Repos.Ef.Repositories;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account";
});
builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(AutoMapping)));

var connectionString = builder.Configuration.GetConnectionString("HSConnection") ?? throw new InvalidOperationException("Connection string 'HSConnection' not found.");
builder.Services.AddScoped<ICommentRepository, CommentRepository>();

builder.Services.AddDbContext<HSDbContext>(options =>
    options.UseSqlServer(connectionString)); 

builder.Services.AddIdentity<IdentityUser<int>, IdentityRole<int>>(
    options=>
    {
        options.SignIn.RequireConfirmedEmail = false;
        options.SignIn.RequireConfirmedPhoneNumber = false;

        options.Password.RequireDigit=false;
        options.Password.RequiredLength = 8;
        options.Password.RequireNonAlphanumeric = false;

    }
    )
    .AddEntityFrameworkStores<HSDbContext>();
// Add services to the container.
builder.Services.AddRazorPages()
     .AddRazorRuntimeCompilation();

builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
