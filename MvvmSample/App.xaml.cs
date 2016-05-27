using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MvvmSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        /// <summary>
        /// Déclenche l'événement <see cref="E:System.Windows.Application.Startup"/>.
        /// </summary>
        /// <param name="e"><see cref="T:System.Windows.StartupEventArgs"/> qui contient les données d'événement.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var bootstrapper = new MvvmSampleBootstrapper();
            bootstrapper.Run();
        }
    }
}
