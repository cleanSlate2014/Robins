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

namespace WpfApplication8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public MainWindow()
{
    InitializeComponent();
    this.SizeChanged += MainWindow_SizeChanged;
}

private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
{
    if (WindowState == System.Windows.WindowState.Normal)
    {
        WindowState = System.Windows.WindowState.Maximized;
    }
}
}
