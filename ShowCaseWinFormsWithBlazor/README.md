# WinForms with Blazor Showcase

This project demonstrates how to integrate Blazor web UI components inside a Windows Forms desktop application using .NET 10.
Idea was thanks to Claudio Bernasconi https://www.telerik.com/blogs/blazor-basics-using-blazor-components-winforms-blazor-hybrid

## 🚀 Features

- **Modern Web UI in Desktop**: Leverages Blazor's component model inside WinForms
- **Glassmorphism Design**: Beautiful modern CSS styling inspired by DariuszPage.html
- **Interactive Components**: Full Blazor functionality including state management and event handling
- **Responsive Layout**: Adapts to different window sizes
- **Animated UI**: Smooth transitions and gradient animations

## 🏗️ Project Structure

```
ShowCaseWinFormsWithBlazor/
├── Program.cs                  # Application entry point
├── MainForm.cs                 # WinForms host with BlazorWebView
├── App.razor                   # Blazor root component with routing
├── _Imports.razor              # Global Razor imports
├── Pages/
│   └── Index.razor             # Main showcase page with interactive features
├── wwwroot/
│   ├── index.html              # HTML host page
│   └── css/
│       └── app.css             # Styling with glassmorphism effects
└── DariuszPage.html            # Original inspiration (static S3 page)
```

## 🎨 Design Elements

The Blazor page features the same design language as DariuszPage.html:
- **Gradient background** (purple to violet)
- **Glassmorphism effects** with backdrop blur
- **Animated text gradients**
- **Hover animations** on interactive elements
- **Feature grid** showcasing technologies
- **Responsive design** for various window sizes

## 🎮 Interactive Features

The showcase includes an interactive counter component demonstrating:
- Real-time UI updates
- Event handling (@onclick)
- Component state management
- Blazor's reactive rendering

## 🛠️ Technologies Used

- **.NET 10** - Latest .NET framework
- **Windows Forms** - Desktop application host
- **Blazor WebView** - Embedded web UI framework
- **CSS3** - Modern styling with animations and effects
- **Razor Components** - Component-based UI

## 🚀 How to Run

1. Open the solution in Visual Studio 2025 or later
2. Ensure .NET 10 SDK is installed
3. Press F5 or click "Start" to run the application
4. The WinForms window will open with the Blazor UI embedded inside

## 📝 Key Implementation Details

### BlazorWebView Integration
The `MainForm.cs` creates a `BlazorWebView` control that hosts the Blazor application:
- Services are configured with `AddWindowsFormsBlazorWebView()`
- The host page is set to `wwwroot/index.html`
- Root component is registered with `RootComponents.Add<App>("#app")`

### Razor Component SDK
The project uses `Microsoft.NET.Sdk.Razor` SDK to enable Razor component compilation alongside WinForms code.

### Styling Approach
CSS is kept similar to the original DariuszPage.html with:
- CSS custom properties for theming
- Keyframe animations for smooth effects
- Grid layout for responsive features
- Glassmorphism using backdrop-filter

## 🎓 Learning Objectives

This showcase demonstrates:
1. How to integrate modern web UI frameworks into legacy desktop applications
2. Best practices for hosting Blazor in WinForms
3. Maintaining consistent design language across platforms
4. Building interactive desktop applications with web technologies

## 👨‍💻 Credits

Design inspiration from **Dariusz Tomczak**'s AWS S3 static website project.

---

**Built with ❤️ using .NET 10, WinForms, and Blazor**
