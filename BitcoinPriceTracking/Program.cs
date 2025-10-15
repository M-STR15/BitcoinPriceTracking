using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using BitcoinPriceTracking.Data;
using BitcoinPriceTracking.BE.Shared.Services;
using BitcoinPriceTracking.BE.BusinessLogic.Services;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddHttpClient("ApiClient", (sp, client) =>
{
	var httpContextAccessor = sp.GetRequiredService<IHttpContextAccessor>();
	var request = httpContextAccessor.HttpContext?.Request;

	var baseAddress = request != null ? $"{request.Scheme}://{request.Host.Value}" : "https://localhost:5157/";
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

builder.Services.AddControllers();
builder.Services.AddBitcoinPriceTrackingBeSharedServices();
builder.Services.AddBitcoinPriceTrackingBeBusinessLogicServices();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
	//var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
	//var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

	var beXmlPath = Path.Combine(AppContext.BaseDirectory, "BitcoinPriceTracking.BE.BusinessLogic.xml");

	//options.IncludeXmlComments(xmlPath);
	options.IncludeXmlComments(beXmlPath);
	options.EnableAnnotations();
	options.SwaggerDoc("v1", new OpenApiInfo
	{
		Title = "BitcoinPriceTrackingAPI",
		Version = "v1",
		Description = ""
	});

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
	c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1");
	c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.List);
});

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.MapControllers();

app.Run();
