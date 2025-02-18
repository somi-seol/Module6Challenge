var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Add this line to enable serving static files
app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");

app.Run();