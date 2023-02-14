using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

// TODO: L�gg till preview av hur f�rdiga formul�ret ser ut
// TODO: Vid fokusering p� fr�ga ska den expanda och visa inneh�llet beroende p� vilket alternativ man valt i dropdown
// TODO: 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

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
