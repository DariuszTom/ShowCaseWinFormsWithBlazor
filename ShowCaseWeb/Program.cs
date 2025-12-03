using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using ShowCaseShared.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorPages();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSingleton<CounterService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
///
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

// Anti-forgery must be registered in the pipeline after authentication/authorization and before endpoints
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<ShowCaseShared.App>()
    .AddInteractiveServerRenderMode();

app.Run();
