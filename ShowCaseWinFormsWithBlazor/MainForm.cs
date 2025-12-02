using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using ShowCaseShared.Services;

namespace ShowCaseWinFormsWithBlazor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();            
            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
#if DEBUG
            services.AddBlazorWebViewDeveloperTools();
#endif
            services.AddSingleton<CounterService>();
            
            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<ShowCaseShared.App>("#app");
        }

        private void InitializeComponent()
        {
            this.blazorWebView1 = new BlazorWebView();
            this.SuspendLayout();
            
            // blazorWebView1
            this.blazorWebView1.Dock = DockStyle.Fill;
            this.blazorWebView1.Location = new Point(0, 0);
            this.blazorWebView1.Name = "blazorWebView1";
            this.blazorWebView1.Size = new Size(1200, 800);
            this.blazorWebView1.TabIndex = 0;
            
            // MainForm
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1200, 800);
            this.Controls.Add(this.blazorWebView1);
            this.Name = "MainForm";
            this.Text = "WinForms with Blazor Showcase";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private BlazorWebView blazorWebView1;
    }
}
