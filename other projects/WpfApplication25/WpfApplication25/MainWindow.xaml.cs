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
using xy = System.Windows.Forms;

namespace WpfApplication25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Color AdjustBrightness(double brightnessFactor)
        {
            Color originalColour = Color.Red;
            Color adjustedColour = Color.FromArgb(originalColour.A,(int)(originalColour.R * brightnessFactor),(int)(originalColour.G * brightnessFactor),(int)(originalColour.B * brightnessFactor));
            return adjustedColour;
        }
        private void xx_Click_1(object sender, RoutedEventArgs e)
        {
            Brush x = xx.Background;
            /*byte a = ((Color)x.GetValue(SolidColorBrush.ColorProperty)).A;
            byte g = ((Color)x.GetValue(SolidColorBrush.ColorProperty)).G;
            byte r = ((Color)x.GetValue(SolidColorBrush.ColorProperty)).R;
            byte b = ((Color)x.GetValue(SolidColorBrush.ColorProperty)).B;*/
            Console.WriteLine(x is SolidColorBrush);
            //new SolidColorBrush(AdjustBrightness(((SolidColorBrush)x).Color));
            //Color.FromArgb((int)a, r, g, b);
            
        }
    }
}
