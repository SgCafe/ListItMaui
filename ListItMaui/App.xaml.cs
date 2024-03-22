using ListItMaui.Services;
using Microsoft.Maui.Controls;

namespace ListItMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<IProductService, ProductService>();
            MainPage = new AppShell();
        }
    }
}