using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

// Get the port from env, or default to 8080 (i.e. running in Heroku port is assigned via environment)
string port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://+:{port}");

app.UseDefaultFiles();    // Looks for index.html
app.UseStaticFiles();     // Serves files from wwwroot

/*
 * In SPAs, routing is often handled entirely in the browser using JavaScript (i.e. hash routes or history API).
 * example: When a user visits /about, the browser expects a response from the server, but there’s no /about physical file on the server — just the SPA in index.html. Without this fallback, the server would return a 404.
 * With this fallback, the server responds with the SPA’s entry point (index.html) for all unmatched paths, and the browser’s JS router handles the actual route from there.
 * Therefore, this is required since we're building a client-side routed SPA (like React, Vue, Angular, or even a vanilla TypeScript SPA that uses pushState routing).
 */
app.MapFallbackToFile("index.html"); // For SPA routing

app.Run();