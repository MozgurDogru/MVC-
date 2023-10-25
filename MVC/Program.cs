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

app.UseHttpsRedirection();//HTTP isteklerinyönlendirilmesini saðlar.
app.UseStaticFiles();//Harici dosyalar için(css-js vs...)WWWroot klasörünükullanmamýzý saðlar.

app.UseRouting();//Gelen isteðin rotasýnýnbelirlenmesini saðlar.(Hangi kontroller-hangi action)

app.UseAuthorization();//Doðrulamayý dahil eder.

app.MapControllerRoute(//Kullanýlacak olan adresleme düzeni.
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
