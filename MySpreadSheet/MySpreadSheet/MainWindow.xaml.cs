using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MySpreadSheet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded +=MainWindow_Loaded;

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MessageDialogBox mdb = new MessageDialogBox(" Microsoft is conducting an online survey to understand your opinion of the Visual Studio Developer Center. If you choose to participate, the online survey will be presented to you when you leave the Visual Studio Developer Center.Would you like to participate?", "Please help us to improve");
            mdb.Display();
        }
    }
}
