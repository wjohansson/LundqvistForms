using LundqvistForms.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor;
using MudBlazor.Services;

// TODO: L�gg till preview av hur f�rdiga formul�ret ser ut
// TODO: Vid fokusering p� fr�ga ska den expanda och visa inneh�llet beroende p� vilket alternativ man valt i dropdown
// TODO: L�gg till m�hlighet att v�lja f�rgtema
// TODO: L�gg till charts med statistik p� svarade formul�r
// TODO: Fixa alla knappar s� att dom tar bort eller l�gger till i databasen ocks�
// TODO: Kolla varf�r det inte g�r att anv�nda include
// TODO: Kolla om man kan anv�nda await ist�llet f�r att k�ra .Result
// TODO: Fixa preserved state vid reload och kanske �ven vid byte av session
// TODO: Kunna dela alla mallar mellan varadra, kan g�ras genom att alla f�r se alla formul�r och skapa en kopia p� sin egen anv�ndare

// SIDA: �versikt �ver alla formul�r. Kan edita rubrik och andra stora properties
// SIDA: Se det f�rdiga formul�ret, f�rhandsgranskning

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();

builder.Services.AddHttpClient<HttpClientWrapper>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5000");
});

builder.Services.AddSingleton<FormServiceUi>();
builder.Services.AddSingleton<SegmentServiceUi>();
builder.Services.AddSingleton<QuestionServiceUi>();
builder.Services.AddSingleton<AnswerServiceUi>();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
