using System.Globalization;
using HoaP.Application.Interfaces;
using HoaP.Application.Mappings;
using HoaP.Application.Services;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using HoaP.Infrastructure.Repositories;
using HoaP.Infrastructure.Services;
using HoaP.Web.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Infrastructure;
using HoaP.Infrastructure.HealthChecks;
using HoaP.Infrastructure.Middleware;
using HoaP.Web.Endpoints;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(CustomerProfile));
builder.Services.AddAutoMapper(typeof(RoomProfile));
builder.Services.AddAutoMapper(typeof(AmenityProfile));
builder.Services.AddAutoMapper(typeof(ReservationProfile));
builder.Services.AddAutoMapper(typeof(InvoiceProfile));
builder.Services.AddAutoMapper(typeof(PaymentProfile));
builder.Services.AddAutoMapper(typeof(EmployeeProfile));
builder.Services.AddAutoMapper(typeof(PaymentMethodProfile));
builder.Services.AddAutoMapper(typeof(RoomStatusProfile));
builder.Services.AddAutoMapper(typeof(RoomTypeProfile));
builder.Services.AddAutoMapper(typeof(InsuranceCompanyProfile));
builder.Services.AddAutoMapper(typeof(CurrencyProfile));
builder.Services.AddAutoMapper(typeof(MealPlanProfile));
builder.Services.AddAutoMapper(typeof(RoleProfile));
builder.Services.AddAutoMapper(typeof(ReservationStatusProfile));
builder.Services.AddAutoMapper(typeof(TaskProfile));
builder.Services.AddAutoMapper(typeof(AccountProfile));
builder.Services.AddAutoMapper(typeof(ReviewProfile));
builder.Services.AddAutoMapper(typeof(ServiceProfile));
builder.Services.AddAutoMapper(typeof(HotelProfileProfile));
builder.Services.AddAutoMapper(typeof(RatePlanProfile));

builder.Services.AddLocalization();

// Nastav v�choz� kulturu na �e�tinu
var defaultCulture = new CultureInfo("cs-CZ");
CultureInfo.DefaultThreadCurrentCulture = defaultCulture;
CultureInfo.DefaultThreadCurrentUICulture = defaultCulture;

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = true;

    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
});


builder.Services.ConfigureApplicationCookie(options =>
{
    options.ExpireTimeSpan = TimeSpan.FromDays(1);
    options.SlidingExpiration = false;
    options.Cookie.HttpOnly = true;
    options.LoginPath = "/login";


});

builder.Services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();




builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<CustomerService>();

builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<RoomService>();

builder.Services.AddScoped<IAmenityRepository, AmenityRepository>();
builder.Services.AddScoped<AmenityService>();

builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
builder.Services.AddScoped<ReservationService>();

builder.Services.AddScoped<IInvoiceRepository, InvoiceRepository>();
builder.Services.AddScoped<InvoiceService>();

builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddScoped<PaymentService>();

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<EmployeeService>();

builder.Services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
builder.Services.AddScoped<PaymentMethodService>();

builder.Services.AddScoped<IRoomTypeRepository, RoomTypeRepository>();
builder.Services.AddScoped<RoomTypeService>();

builder.Services.AddScoped<IRoomStatusRepository, RoomStatusRepository>();
builder.Services.AddScoped<RoomStatusService>();

builder.Services.AddScoped<IInsuranceCompanyRepository, InsuranceCompanyRepository>();
builder.Services.AddScoped<InsuranceCompanyService>();

builder.Services.AddScoped<ICurrencyRepository, CurrencyRepository>();
builder.Services.AddScoped<CurrencyService>();

builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<AccountService>();

builder.Services.AddScoped<IDashBoardRepository, DashBoardRepository>();
builder.Services.AddScoped<DashBoardService>();

builder.Services.AddScoped<IMealPlanRepository, MealPlanRepository>();
builder.Services.AddScoped<MealPlanService>();

builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<RoleService>();

builder.Services.AddScoped<IReservationStatusRepository, ReservationStatusRepository>();
builder.Services.AddScoped<ReservationStatusService>();

builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddScoped<TaskService>();

builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<ReviewService>();

builder.Services.AddScoped<IFileUploadService, FileUploadService>();

builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<AddonService>();

builder.Services.AddScoped<IHotelProfileRepository, HotelProfileRepository>();
builder.Services.AddScoped<HotelProfileService>();

builder.Services.AddScoped<IRatePlanRepository, RatePlanRepository>();
builder.Services.AddScoped<RatePlanService>();

builder.Services.AddScoped<IReportRepository, ReportRepository>();
builder.Services.AddScoped<ReportService>();

builder.Services.AddSingleton<IEncryptionService, AesEncryptionService>();

builder.Services.AddSingleton<MockPaymentGatewayService>();
builder.Services.AddSingleton<IPaymentGatewayService>(sp => sp.GetRequiredService<MockPaymentGatewayService>());

builder.Services.AddScoped<InvoicePdfGenerator>();

// Multi-tenancy
builder.Services.AddDbContext<MasterDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("MasterConnection")
        ?? throw new InvalidOperationException("Connection string 'MasterConnection' not found.")));

builder.Services.AddScoped<ITenantService, TenantService>();
builder.Services.AddScoped<TenantDbContextFactory>();
builder.Services.AddScoped<TenantDatabaseProvisioner>();

// Health checks
builder.Services.AddHealthChecks()
    .AddMySql(
        builder.Configuration.GetConnectionString("DefaultConnection")!,
        name: "mysql",
        tags: new[] { "db", "ready" })
    .AddCheck<EncryptionServiceHealthCheck>(
        "encryption",
        tags: new[] { "security", "ready" })
    .AddCheck<DiskSpaceHealthCheck>(
        "disk-space",
        tags: new[] { "infrastructure" });





var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    await DbInitializer.SeedAdminAsync(scope.ServiceProvider);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<TenantResolutionMiddleware>();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Health check endpoints
app.MapHealthChecks("/health", new HealthCheckOptions
{
    Predicate = _ => true,
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});
app.MapHealthChecks("/health/ready", new HealthCheckOptions
{
    Predicate = check => check.Tags.Contains("ready"),
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

// Map API endpoints
app.MapRoomEndpoints();
app.MapReservationEndpoints();
app.MapCustomerEndpoints();
app.MapInvoiceEndpoints();
app.MapDashboardEndpoints();
app.MapRatePlanEndpoints();
app.MapReportEndpoints();
app.MapPaymentGatewayEndpoints();
app.MapTenantEndpoints();

QuestPDF.Settings.License = LicenseType.Community;



app.Run();
