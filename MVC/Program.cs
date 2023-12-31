var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();//HTTP isteklerinyönlendirilmesini sağlar.
app.UseStaticFiles();//Harici dosyalar için(css-js vs...)WWWroot klasörünükullanmamızı sağlar.

app.UseRouting();//Gelen isteğin rotasınınbelirlenmesini sağlar.(Hangi kontroller-hangi action)

app.UseAuthorization();//Doğrulamayı dahil eder.

app.MapControllerRoute(//Kullanılacak olan adresleme düzeni.
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
