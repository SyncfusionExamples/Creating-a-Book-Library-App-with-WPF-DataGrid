using Syncfusion.Licensing;
using System.Configuration;
using System.Data;
using System.Windows;

namespace BookLibraryDemoWithWPFDataGrid;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        SyncfusionLicenseProvider.RegisterLicense("MDAxQDMyMzkyZTMwMmUzMDNiMzIzOTNiaVZBaENhb2xTY1lRMU43cFVyZUxtY3VTSG5qZEk5Nm5XaG01RTcxais4OD0=");
    }
}

