using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using BitcoinPriceTracking.Data;
using BitcoinPriceTracking.BE.Shared.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddHttpClient("ApiClient", (sp, client) =>
{
	var httpContextAccessor = sp.GetRequiredService<IHttpContextAccessor>();
	var request = httpContextAccessor.HttpContext?.Request;

	var baseAddress = request != null ? $"{request.Scheme}://{request.Host.Value}" : "https://localhost:7246/";
	client.BaseAddress = new Uri(baseAddress);
});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSingleton<IEventLogService, EventLogService>();


builder.Services.AddHostedService<TimedHostedService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
