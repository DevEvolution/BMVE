using BMVE.Core.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace BMVE
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        App()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            App app = new App();
            CodeView.ClassToExecute = new Code();
            var codeview = new CodeView()
            {
                Title = "MainView"
            };
            //codeview.Show();
            app.Run(codeview);
        }
    }
}
