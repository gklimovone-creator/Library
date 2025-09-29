var builder = WebApplication.CreateBuilder(args);

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

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.SetDefaultCulture("ru-RU");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.MapControllers(); // ← И ЭТО ВАЖНО!

app.Run();