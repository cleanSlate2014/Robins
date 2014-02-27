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



namespace CustomControlsLibrary
{
 
   partial class Dictionary1
    {

       
       private void ButtonDown(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("ButtonDown");
           Button myButton = sender as Button;
           Brush buttonDark = myButton.Background;
           Colorpicker colorPicker = new Colorpicker(buttonDark);
           myButton.Background = colorPicker.darker();
           
       }//Button Down method ends here


       private void ButtonUp(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("Button Up");
           MessageBox.Show("Hello");
           Button myButton = sender as Button;
           Brush buttonDark = myButton.Background;
           Colorpicker colorPicker = new Colorpicker(buttonDark);
           myButton.Background = colorPicker.lighter();
           
       }//ButtonUp method ends here


       private void ButtonLeave(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("ButtonLeave");
           Button myButton = sender as Button;
           Brush buttonDark = myButton.Background;
           Colorpicker colorPicker = new Colorpicker(buttonDark);
           myButton.Background = colorPicker.light();
       }


       private void ButtonEnter(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("ButtonEnter");
           Button myButton = sender as Button;
           Brush buttonDark = myButton.Background;
           Colorpicker colorPicker = new Colorpicker(buttonDark);
           myButton.Background = colorPicker.dark();
       }
       private void borderLoaded(object sender, RoutedEventArgs e)
       {
           
       }



    }



    class ButtonDefault:
    
    
}
