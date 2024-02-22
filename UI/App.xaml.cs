using System.Configuration;
using System.Data;
using System.Windows;

namespace UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Activated += StartElmish;
        }

        void StartElmish(object? sender, EventArgs e)
        {
            this.Activated -= StartElmish;
            Gaga.Program.main(MainWindow);
        }
    }

}
