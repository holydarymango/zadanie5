using Microsoft.EntityFrameworkCore.Infrastructure;
using PR_5.Model;
using System.Configuration;
using System.Data;
using System.Windows;

namespace PR_5
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade facade = new DatabaseFacade(new DataContext());
            facade.EnsureCreated();
        }
    }

}
