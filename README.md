# ShowCaseSuite

A multi-platform Blazor showcase targeting .NET 10. It demonstrates sharing a single Blazor UI across:
- WebAssembly (browser)
- ASP.NET Core (server-rendered)
- .NET MAUI (mobile/desktop hybrid)
- Windows Forms with BlazorWebView (desktop)
- Shared Razor Components library reused by all hosts

## Projects

- `ShowCaseShared/` (Microsoft.NET.Sdk.Razor)
  - `App.razor` root and routing
  - `Pages/Index.razor` shared landing page with interactive counter
  - `wwwroot/css/app.css` common styling
  - `Services/CounterService.cs` shared state service

- `ShowCaseWebAsembly/` (Blazor WebAssembly)
  - `Program.cs` bootstraps WASM
  - `wwwroot/index.html` uses `_framework/blazor.webassembly.js`
  - `App.razor` includes `AdditionalAssemblies` to discover routes from `ShowCaseShared`
  - Renders shared `Index` at `/` and local `Home` at `/hello`

- `ShowCaseWeb/` (ASP.NET Core Server)
  - `Program.cs` configures Razor Components and server interactivity
  - `Components/App.razor` and `Components/Routes.razor`
  - Reuses `ShowCaseShared.App` and pages

- `ShowCaseMobile/` (.NET MAUI)
  - `MauiProgram.cs` adds `AddMauiBlazorWebView()` and registers `CounterService`
  - `MainPage.xaml` hosts `ShowCaseShared.App` via `<BlazorWebView>`
  - `wwwroot/index.html` uses `_framework/blazor.webview.js` (required for MAUI)

- `ShowCaseWinFormsWithBlazor/` (Windows Forms)
  - `MainForm.cs` hosts Blazor via `BlazorWebView`
  - Root component: `ShowCaseShared.App`
  - `wwwroot/index.html` uses `_framework/blazor.webview.js`

## Key Features
- Single shared UI (`ShowCaseShared`) rendered consistently across all hosts
- Gradient + glassmorphism design
- Interactive counter with animations and shared state
- Responsive layout

## Run
1. Ensure .NET 10 SDK.
2. Open the solution in Visual Studio 2025+.
3. Start any host:
   - WebAssembly: `ShowCaseWebAsembly`
   - Server: `ShowCaseWeb`
   - MAUI: `ShowCaseMobile` (Android/iOS/Windows/MacCatalyst)
   - WinForms: `ShowCaseWinFormsWithBlazor`

## Troubleshooting
- MAUI/WinForms must use `_framework/blazor.webview.js` in host `index.html`.
- WebAssembly must use `_framework/blazor.webassembly.js`.
- If WASM shows the template page, ensure `ShowCaseWebAsembly/App.razor` includes `AdditionalAssemblies` pointing to `ShowCaseShared`.
- Clear browser cache or restart app after changing host pages.

## Credits
- Design inspiration by Dariusz Tomczak.
- Initial idea reference: Claudio Bernasconi (Telerik blog on hosting Blazor in WinForms).

---

**Built with ❤️ using .NET 10, WinForms, and Blazor**
