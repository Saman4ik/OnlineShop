var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("LocalDb")));

builder.Services.AddTransient<ICategoryInterface, CategoryRepository>();
builder.Services.AddTransient<IImageInterface, ImageRepository>();
builder.Services.AddTransient<IOrderItmesInterface, OrderItmesRepository>();
builder.Services.AddTransient<IOrdersInterface, OrderRepository>();
builder.Services.AddTransient<IProductInterface, ProductRepository>();
builder.Services.AddTransient<ISubCategoryInterface, SubCategoryRepository>();
builder.Services.AddTransient<IUserInterface, UserRepository>();





var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
