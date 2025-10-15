using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using BitcoinPriceTracking.Data;
using BitcoinPriceTracking.BE.Shared.Services;
using BitcoinPriceTracking.BE.BusinessLogic.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddHttpClient("ApiClient", (sp, client) =>
{
	var httpContextAccessor = sp.GetRequiredService<IHttpContextAccessor>();
	var request = httpContextAccessor.HttpContext?.Request;

	var baseAddress = request != null ? $"{request.Scheme}://{request.Host.Value}" : "https://localhost:7246/";
	client.BaseAddress = new Uri(baseAddress);
});

builder.Services.AddHttpClient("ApiCoindeskClient", (sp, client) =>
{
	var httpContextAccessor = sp.GetRequiredService<IHttpContextAccessor>();
	var baseAddress = "https://data-api.coindesk.com/";
	client.BaseAddress = new Uri(baseAddress);
});

builder.Services.AddHttpClient("ApiCNBClient", (sp, client) =>
{
	var httpContextAccessor = sp.GetRequiredService<IHttpContextAccessor>();
	var baseAddress = "https://www.cnb.cz/";
	client.BaseAddress = new Uri(baseAddress);
});

builder.Services.AddBitcoinPriceTrackingBeSharedServices();
builder.Services.AddBitcoinPriceTrackingBeBusinessLogicServices();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

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
