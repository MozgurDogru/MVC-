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

app.UseHttpsRedirection();//HTTP istekleriny�nlendirilmesini sa�lar.
app.UseStaticFiles();//Harici dosyalar i�in(css-js vs...)WWWroot klas�r�n�kullanmam�z� sa�lar.

app.UseRouting();//Gelen iste�in rotas�n�nbelirlenmesini sa�lar.(Hangi kontroller-hangi action)

app.UseAuthorization();//Do�rulamay� dahil eder.

app.MapControllerRoute(//Kullan�lacak olan adresleme d�zeni.
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
