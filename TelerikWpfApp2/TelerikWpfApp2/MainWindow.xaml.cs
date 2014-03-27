using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace TelerikWpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          /*  List<Data> data = new List<Data>();
            data.Add(new Data() { Category = "Apples", Value = 5 });
            data.Add(new Data() { Category = "Oranges", Value = 9 });
            data.Add(new Data() { Category = "Pineaples", Value = 8 });
            
            this.lineSeries.DataContext = data;*/
            
        }
    }

    public class Data
    {
        public string Category { get; set; }

        public double Value { get; set; }
    }


}
