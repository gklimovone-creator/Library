using Microsoft.Extensions.Options;
using LibraryManagement.Domain.Interfaces;
using LibraryManagement.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Регистрируем LibrarySettings в DI контейнере, привязывая к секции "LibrarySettings" в appsettings.json
//builder.Services.Configure<LibrarySettings>(builder.Configuration.GetSection("LibrarySettings"));

// Регистрируем сервис для доступа к настройкам
builder.Services.AddScoped<ILibrarySettingsService, LibrarySettingsService>();


// Add services to the container.
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null;  // оставляет названия полей как в классе C#
        options.JsonSerializerOptions.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping; // разрешает кириллицу в JSON
        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;   // делает названия полей нечувствительными к регистру
    });

// Настройка кодировки для кириллицы
builder.Services.Configure<ConsoleLifetimeOptions>(options =>
{
    options.SuppressStatusMessages = true;
});

//builder.Services.Configure<RequestLocalizationOptions>(options =>
//{
//    options.SetDefaultCulture("ru-RU");
//});

var app = builder.Build();

//Тестовый маршрут для проверки настроек
app.Map("/test-settings", (ILibrarySettingsService settings) => $"Библиотека: {settings.GetLibraryName()}, Срок аренды: {settings.GetDefaultLoanDays()} дней");
if
    (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//app.Map("/settings", (IOptions<LibrarySettings> settings) =>
//app.Map("/settings", (LibrarySettingsService settingsService) =>

//{
//    // Просто возвращаем JSON с настройками из сервиса
//    return Results.Json(settingsService.GetSettings());
//});



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.MapControllers(); // ← И ЭТО ВАЖНО!

app.Run();

