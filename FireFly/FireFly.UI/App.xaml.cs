using FireFly.Data;
using FireFly.Data.Repositories.SystemSetting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace FireFly.UI
{
    public partial class App : Application
    {
        //private ServiceProvider serviceProvider;

        //public App()
        //{
        //    ServiceCollection service = new ServiceCollection();
        //    ConfigureServices(service);
        //    serviceProvider = service.BuildServiceProvider();
        //}

        //private void ConfigureServices(ServiceCollection service)
        //{
        //    //            service.AddDbContext<FireFlyContext>(option =>
        //    //            {
        //    //                option.UseSqlite("ConnectionString");
        //    //            });
        //    //)
        //}

        //private void OnStartup(object sender, StartupEventArgs e)
        //{
        //    serviceProvider.GetService<SystemSettingsRepository>();

        //}
    }
}