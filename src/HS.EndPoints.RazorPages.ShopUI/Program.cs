using Framework.Utilities;
using HS.Domain.ApplicationServices;
using HS.Domain.Core.ConfigurationModel;
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
using System.Configuration;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);


builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddSeq("http://185.55.226.248:5341/", "u6eA9I6VidVTRQJHCSWT");



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
    options =>
    {
        options.SignIn.RequireConfirmedEmail = true;
        options.SignIn.RequireConfirmedPhoneNumber = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Lockout.MaxFailedAccessAttempts = 5;
        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 4;
        options.Password.RequireNonAlphanumeric = false;

    }
    )
.AddEntityFrameworkStores<HSDbContext>()
.AddErrorDescriber<PersianIdentityErrorDescriber>() ;
    
builder.Services.Configure<EmailConfiguration>(builder.Configuration
    .GetSection("EmailConfiguration"));

builder.Services.Configure<SmsConfiguration>(builder.Configuration
    .GetSection("SmsSettings"));


builder.Services.AddRecaptchaService();



builder.Services.AddRazorPages()
     .AddRazorRuntimeCompilation();
builder.Services.AddCors();
builder.Services.AddMvc()
    .AddSessionStateTempDataProvider();
builder.Services.AddServerSideBlazor();

builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();
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

builder.Services.AddScoped<IHomeServiceSubCategoryApplicationService, HomeServiceSubCategoryApplicationService>();
builder.Services.AddScoped<IHomeServiceSubCategoryRepository, HomeServiceSubCategoryRepository>();
builder.Services.AddScoped<IHomeServiceSubCategoryService, HomeServiceSubCategoryService>();


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

builder.Services.AddScoped<IHomeServiceCategoryApplicationService, HomeServiceCategoryApplicationService>();
builder.Services.AddScoped<IHomeServiceCategoryRepository, HomeServiceCategoryRepository>();
builder.Services.AddScoped<IHomeServiceCategoryService, HomeServiceCategoryService>();

builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<ISmsService, SmsService>();

//builder.Services.AddStackExchangeRedisCache(options =>
//{
//    options.Configuration = "localhost:9191,password=123456";
//    options.InstanceName = "soonService";
//});

builder.Services.AddMemoryCache();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
app.UseSession();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseMiddleware<LoggingMiddleware>();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseCors(builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.MapRazorPages();
app.MapBlazorHub();


app.Run();
