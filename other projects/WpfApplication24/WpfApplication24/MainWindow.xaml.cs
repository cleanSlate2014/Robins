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

namespace WpfApplication24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Style style = App.Current.Resources["button_style"] as Style;
            Console.WriteLine("hi");
            Style new_style = new Style();
            new_style.BasedOn = style;
            new_style.TargetType = typeof(Button);
            new_style.Setters.Add(new Setter(Button.BackgroundProperty, Brushes.Black));
            x.Style = new_style;

            ControlTemplate template = App.Current.Resources["my_button"] as ControlTemplate;
        }
    }
}
