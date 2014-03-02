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





       private void RadioMouseEnter(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("RadioButton Mouse Enter/GotFocused");
           RadioButton radioButton = sender as RadioButton;
           Brush radioColor = radioButton.Background;
           Colorpicker colorPicker = new Colorpicker(radioColor);
           radioButton.Background = colorPicker.dark();
       }





       private void RadioMouseLeave(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("RadioButton Mouse Leave/FocusLost");
           RadioButton radioButton = sender as RadioButton;
           Brush radioColor = radioButton.Background;
           Colorpicker colorPicker = new Colorpicker(radioColor);
           radioButton.Background = colorPicker.light();
       }

       //Event for RadioLeftButtonDownEnable..
       private void RadioMouseDownEnable(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("RadioButton MouseDown Enable");
           CustomRadioButton radioButton = sender as CustomRadioButton;
           Brush radioColor = radioButton.Background;
           Colorpicker colorPicker = new Colorpicker(radioColor);
           //Storing previous value of RadioButton value...
           radioButton.EnableColor = radioColor;
           radioButton.Background = colorPicker.darker();
       }



       //Event for RadioLeftButtonUpEnable..
       private void RadioMouseUpEnable(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("RadioButton MouseUp Enable");
           CustomRadioButton radioButton = sender as CustomRadioButton;
           Brush radioColor = radioButton.Background;
           Colorpicker colorPicker = new Colorpicker(radioColor);
           radioButton.Background = colorPicker.lighter();
           Console.WriteLine(radioButton.Disabled);
           if (radioButton.Disabled == true)
           {
               Console.WriteLine("Radio button mouseup is writing new values");
               Console.WriteLine(radioButton.Background);
               radioButton.Background = radioButton.InitialValue;
               //radioButton.Background = radioButton.EnableColor;
               radioButton.DisableColor = new SolidColorBrush(Color.FromRgb(215, 215, 219));
               Console.WriteLine(radioButton.Background);
               radioButton.Disabled = false;
               Console.WriteLine(radioButton.Disabled);
           }
       }

   
       //Event for RadioLeftButtonDisable..
       private void RadioMouseDownDisable(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("RadioButton MouseDown Disable");
           RadioButton radioButton = sender as RadioButton;
           Brush radioColor = radioButton.Background;
           Colorpicker colorPicker = new Colorpicker(radioColor);
           radioButton.Background = colorPicker.darker();
       }


       //Event for RadioLeftButtonDisable..
       private void RadioMouseUpDisable(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("RadioButton MouseDown Disable");
           CustomRadioButton radioButton = sender as CustomRadioButton;
           Brush radioColor = radioButton.Background;
           Colorpicker colorPicker = new Colorpicker(radioColor);
           radioButton.Background = colorPicker.lighter();
           Console.WriteLine(radioButton.Disabled);
           if (radioButton.Disabled == false)
           {
               //Converting back to Primary color
               radioButton.Disabled = true;
               Console.WriteLine("Disabled Background Color\n");
               Console.WriteLine(radioButton.EnableColor);
               //radioButton.Background = new SolidColorBrush(Color.FromRgb(66,139,202)) ;
               radioButton.Background = radioButton.EnableColor;
               Console.WriteLine(radioButton.EnableColor);
               //Now changing the DisableButton Color new SolidColorBrush(Color.FromRgb(239, 239, 240))
               radioButton.EnableColor = new SolidColorBrush(Color.FromRgb(215,215,219));
               radioButton.Disabled = true;
               Console.WriteLine(radioButton.Disabled);

              
           }
           
       }


    }//Partial class Dictionary1 Ends here..   


   //-----------------------------------------Events for RadioButton Start Here-----------------------------------------
   class CustomRadioButton : RadioButton
   {
       
       //private  Boolean _disable = false;
       public static  DependencyProperty InitialValueProperty = DependencyProperty.Register("InitialValue",typeof(Brush),typeof(CustomRadioButton), new PropertyMetadata(default(Brush)) );
       public static  DependencyProperty DisabledProperty = DependencyProperty.Register("Disabled", typeof(Boolean), typeof(CustomRadioButton), new PropertyMetadata(default(Boolean)));
       public static  DependencyProperty EnableColorProperty = DependencyProperty.Register("EnableColor", typeof(Brush), typeof(CustomRadioButton), new PropertyMetadata(default(Brush)) );
       public static  DependencyProperty DisableColorProperty = DependencyProperty.Register("DisableColor", typeof(Brush), typeof(CustomRadioButton), new PropertyMetadata(default(Brush)) );
       public static  DependencyProperty RadioTypeProperty = DependencyProperty.Register("RadioType", typeof(String), typeof(CustomRadioButton), new FrameworkPropertyMetadata(default(String)) );
     
       public CustomRadioButton() : base()
       {
          //Just call the base class constructor
       }


       public Brush InitialValue
       {
           get
           {
               return (Brush)GetValue(InitialValueProperty);
           }
           set
           {
               SetValue(InitialValueProperty,value);
           }
       }

       public Brush EnableColor
       {
           get
           { return (Brush)GetValue(EnableColorProperty); }

           set
           { 
               SetValue(EnableColorProperty,value);
           }

       }

       public Boolean Disabled
       {
           get
           { return (Boolean)GetValue(DisabledProperty); }

           set
           {
               SetValue(DisabledProperty, value);
           }
       }

       public String RadioType
       {
           get
           { return (String)GetValue(RadioTypeProperty); }

           set
           {
               SetValue(RadioTypeProperty, value);
           }

       }



      public Brush DisableColor
       {
           get
           { return (Brush)GetValue(DisableColorProperty); }

           set
           { 
               SetValue(DisableColorProperty,value);
           }

       }



      
   }
   //CustomRadioButton Class ends here...



}
