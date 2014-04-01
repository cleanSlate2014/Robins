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

namespace WpfApplication6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;

        }



       
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            String body = " Microsoft is conducting an online survey to understand your opinion of the Visual Studio Developer Center. If you choose to participate, the online survey will be presented to you when you leave the Visual Studio Developer Center.Would you like to participate?";
            String title = "Please help us to improve";
            //MessageBox.Show(body + body + body + body + body + body + body + body + body + body + body + body + body + body + body);
            MessageDialogBox mdb = new MessageDialogBox(body  + body + body + body  + body + body + body, MessageDialogBox.NONE);
            mdb.Height = 200;
            mdb.Display();
            MessageDialogBox mdb1 = new MessageDialogBox(title,title,MessageDialogBox.OK);
            //mdb.Height = 200;
            //mdb1.ClickDisable = true;
            mdb1.Display();
            MessageDialogBox mdb2 = new MessageDialogBox(body+body+body, title,MessageDialogBox.OKCANCEL);
            //mdb2.ClickDisable = true;
            //mdb.Height = 200;
            mdb2.Display();
           
            MessageDialogBox mdb3 = new MessageDialogBox(body+body, title, MessageDialogBox.YESNOCANCEL);
            //mdb.Height = 200;
            //mdb3.ClickDisable = true;
            mdb3.Display();
            MessageDialogBox mdb4 = new MessageDialogBox(body, title, MessageDialogBox.OKCANCEL);
            //mdb.Height = 200;
            //mdb4.ClickDisable = true;
            mdb4.Display();
        }
    }
}
