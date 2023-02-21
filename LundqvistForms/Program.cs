using LundqvistForms.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor;
using MudBlazor.Services;

// TODO: Lägg till preview av hur färdiga formuläret ser ut
// TODO: Lägg till möhlighet att välja färgtema
// TODO: Lägg till charts med statistik på svarade formulär
// TODO: Kolla om man kan använda await istället för att köra .Result
// TODO: Fixa preserved state vid reload och kanske även vid byte av session
// TODO: Kunna dela alla mallar mellan varadra, kan göras genom att alla får se alla formulär och skapa en kopia på sin egen användare

// SIDA: Se det färdiga formuläret, förhandsgranskning

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
