using HS.Domain.ApplicationServices;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Entities;
using HS.Domain.Services;
using HS.EndPoints.RazorPages.UI.Model;
using HS.Infrastructures.Database.Repos.Ef.AutoMapper;
using HS.Infrastructures.Database.Repos.Ef.Repositories;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account";
    options.AccessDeniedPath = "/AccessDenied";
});
builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(AutoMapping)));
builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(AutoMappingUi))); 

var connectionString = builder.Configuration.GetConnectionString("HSConnection") ?? throw new InvalidOperationException("Connection string 'HSConnection' not found.");
builder.Services.AddScoped<ICommentRepository, CommentRepository>();

builder.Services.AddDbContext<HSDbContext>(options =>
    options.UseSqlServer(connectionString)); 

builder.Services.AddIdentity<ApplicationUser, IdentityRole<Guid>>(
    options=>
    {
        options.SignIn.RequireConfirmedEmail = false;
        options.SignIn.RequireConfirmedPhoneNumber = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;

        options.Password.RequireDigit=false;
        options.Password.RequiredLength = 8;
        options.Password.RequireNonAlphanumeric = false;

    }
    )
    .AddEntityFrameworkStores<HSDbContext>();

builder.Services.AddRazorPages()
     .AddRazorRuntimeCompilation();
builder.Services.AddMvc()
    .AddSessionStateTempDataProvider();
builder.Services.AddSession();

builder.Services.AddScoped<SeedIdentityData, SeedIdentityData>();

builder.Services.AddScoped<IExpertApplicationService, ExpertApplicationService>();
builder.Services.AddScoped<IExpertRepository, ExpertRepository>();
builder.Services.AddScoped<IExpertService, ExpertService>();

builder.Services.AddScoped<ICityApplicationService, CityApplicationService>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<ICityService, CityService>();

builder.Services.AddScoped<IHomeServiceApplicationService, HomeServiceApplicationService>();
builder.Services.AddScoped<IHomeServiceRepository, HomeServiceRepository>();
builder.Services.AddScoped<IHomeServiceService, HomeServiceService>();

builder.Services.AddScoped<ICustomerApplicationService, CustomerApplicationService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

builder.Services.AddScoped<IOrderApplicationService, OrderApplicationService>();
builder.Services.AddScoped<IOrderRepository, OrdersRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddScoped<ISuggestionApplicationService, SuggestionApplicationService>();
builder.Services.AddScoped<ISuggestionRepository, SuggestionsRepository>();
builder.Services.AddScoped<ISuggestionService, SuggestionService>();

builder.Services.AddScoped<IOrderFileApplicationService, OrderFileApplicationService>();
builder.Services.AddScoped<IOrderFileRepository, OrderFileRepository>();
builder.Services.AddScoped<IOrderFileService, OrderFileService>();

builder.Services.AddScoped<ICommentApplicationService, CommentApplicationService>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<ICommentService, CommentService>();

builder.Services.AddScoped<IApplicationUserApplicationService, ApplicationUserApplicationService>();
builder.Services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
builder.Services.AddScoped<IApplicationUserService, ApplicationUserService>();

builder.Services.AddScoped<IHomeServiceCategoryRepository, HomeServiceCategoryRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSession();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();


 app.Run();
