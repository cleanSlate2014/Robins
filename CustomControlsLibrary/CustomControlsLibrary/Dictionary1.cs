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



       //Now defining class for menu..
       private void MenuMouseDown(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("MouseLeftDown");
           MenuItem menuItem = sender as MenuItem;
           Brush menuItemColor = menuItem.Background;
           Colorpicker colorPicker = new Colorpicker(menuItemColor);
           menuItem.Background = colorPicker.darker();
           
       }


       private void MenuMouseUp(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("MouseLeftUp");
           MenuItem menuItem = sender as MenuItem;
           Brush menuItemColor = menuItem.Background;
           Colorpicker colorPicker = new Colorpicker(menuItemColor);
           menuItem.Background = colorPicker.lighter();
       }


       private void MenuMouseEnter(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("MouseEnter");
           MenuItem menuItem = sender as MenuItem;
           Brush menuItemColor = menuItem.Background;
           Colorpicker colorPicker = new Colorpicker(menuItemColor);
           menuItem.Background = colorPicker.dark();
           Console.WriteLine(menuItem.Background);
       }


       private void MenuMouseLeave(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("MouseLeave");
           MenuItem menuItem = sender as MenuItem;
           Brush menuItemColor = menuItem.Background;
           Colorpicker colorPicker = new Colorpicker(menuItemColor);
           menuItem.Background = colorPicker.light();
       }

       private void MenuItemHighlighted(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("KeyBoard Focused!!");
           MenuItem menuItem = sender as MenuItem;
           Brush itemColor = menuItem.Background;
           Colorpicker colorPicker = new Colorpicker(itemColor);
           menuItem.Background = colorPicker.dark();
       }

       private void FocusLost(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("KeyBoard Focused Lost!!");
           MenuItem menuItem = sender as MenuItem;
           Brush itemColor = menuItem.Background;
           Colorpicker colorPicker = new Colorpicker(itemColor);
           menuItem.Background = colorPicker.light();
       }


       private void MouseEnterItem(object sender, RoutedEventArgs e)
       {
          /* Console.WriteLine("MouseEnterItem");
           Rectangle rect = sender as Rectangle;
           Brush itemColor = rect.Fill;
           Colorpicker colorPicker = new Colorpicker(itemColor);
           rect.Fill = colorPicker.dark(); */
       }

       private void MouseLeaveItem(object sender, RoutedEventArgs e)
       {
          /* Console.WriteLine("MenuItem MouseLeave");
           Rectangle rect = sender as Rectangle;
           Brush itemColor = rect.Fill;
           Colorpicker colorPicker = new Colorpicker(itemColor);
           rect.Fill = colorPicker.light(); */
       }
       

       private void ItemMouseDown(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("MenuItem MouseDown");
           Rectangle rect = sender as Rectangle;
           Brush itemColor = rect.Fill;
           Colorpicker colorPicker = new Colorpicker(itemColor);
           rect.Fill = colorPicker.darker();
       }


       private void ItemMouseUp(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("MenuItem MouseUp");
           Rectangle rect = sender as Rectangle;
           Brush itemColor = rect.Fill;
           Colorpicker colorPicker = new Colorpicker(itemColor);
           rect.Fill = colorPicker.lighter();
       }
      

    }//Partial class Dictionary1 Ends here



  



    
    
    
}
