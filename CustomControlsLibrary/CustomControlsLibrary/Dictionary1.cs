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

    //-------------------------------------------------------------------------EVENT FOR RADIOBUTTON---------------------------------------------------------------------------
       private void RadioButtonDown(object sender, RoutedEventArgs e)
       {
           //Checking the IsChecked property....
           CustomPanel stackPanel = sender as CustomPanel;
           Border radioButtonEnable = stackPanel.FindName("EnableButton") as Border;
           Border radioButtonDisable = stackPanel.FindName("DisableButton") as Border;
           Border radioButton;
           Boolean EnabledFlag = true ;
           try
           {
               ContentPresenter myContent = e.Source as ContentPresenter;
               Console.WriteLine(myContent.Content);
               if ((String)myContent.Tag == "Disable")
               {
                   EnabledFlag = false;
               }
               else 
               {
                   EnabledFlag = true;
               }
           }
           catch (Exception)
           {
               Border myBorder = e.Source as Border;
               if ( (String)myBorder.Tag == "Disable")
               {
                   EnabledFlag = false;
               }
               else
               {
                   EnabledFlag = true;
               }
               
           }
           if (EnabledFlag)
           {
               radioButton = radioButtonEnable;
               Colorpicker colorPicker = new Colorpicker(radioButton.Background);
               radioButton.Background = colorPicker.darker();
              
           }
           else
           {
               radioButton = radioButtonDisable;
               Colorpicker colorPicker = new Colorpicker(radioButton.Background);
               radioButton.Background = colorPicker.darker();
   
           }


           
       }


     
   

       private void RadioButtonUp(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("In button up property");
           //Checking the IsChecked property....
           CustomPanel stackPanel = sender as CustomPanel;
           Border radioButtonEnable = stackPanel.FindName("EnableButton") as Border;
           Border radioButtonDisable = stackPanel.FindName("DisableButton") as Border;
           Border radioButton;
           Boolean EnabledFlag = true;
           
           try
           {
               ContentPresenter myContent = e.Source as ContentPresenter;
              
               if ((String)myContent.Tag == "Disable")
               {
                   EnabledFlag = false;
               }
               else
               {
                   EnabledFlag = true;
               }
           }
           catch (Exception)
           {
               Border myBorder = e.Source as Border;
               if ((String)myBorder.Tag == "Disable")
               {
                   EnabledFlag = false;
               }
               else
               {
                   EnabledFlag = true;
               }

           }
           if (EnabledFlag)
           {
               radioButton = radioButtonEnable;
               Colorpicker colorPicker = new Colorpicker(radioButton.Background);
               radioButton.Background = colorPicker.lighter();

           }
           else
           {
               radioButton = radioButtonDisable;
               Colorpicker colorPicker = new Colorpicker(radioButton.Background);
               radioButton.Background = colorPicker.lighter();

           }

       }

       private void RadioButtonEnter(object sender, RoutedEventArgs e)
       {
        
        
       }


       private void RadioButtonLeave(object sender, RoutedEventArgs e)
       {
       }

       //Creating a loaded event
       private void RadioButtonOnLoad(object sender, RoutedEventArgs e)
       {
           Console.WriteLine("I am loaded");
           SwitchButton myPanel = sender as SwitchButton;
           //myPanel.IsChecked = true;
           Console.WriteLine(myPanel.Check);
           myPanel.Check = false;

       }



      

    }//Partial class Dictionary1 Ends here..   

   class SwitchButton : RadioButton
   {
       public static readonly DependencyProperty CheckProperty = DependencyProperty.Register("Check", typeof(Boolean), typeof(SwitchButton), new PropertyMetadata(new PropertyChangedCallback(OnCheckedChanged)));
       public static readonly DependencyProperty DisableColorProperty = DependencyProperty.Register("DisableColor", typeof(Brush), typeof(SwitchButton), new PropertyMetadata(default(Brush)));
       public static readonly DependencyProperty EnableColorProperty = DependencyProperty.Register("EnableColor", typeof(Brush), typeof(SwitchButton), new PropertyMetadata(default(Brush)));
       public static readonly DependencyProperty InitialEnabledValueProperty = DependencyProperty.Register("InitialEnabledValue", typeof(Brush), typeof(SwitchButton), new PropertyMetadata(default(Brush)));
       public static readonly DependencyProperty InitialDisabledValueProperty = DependencyProperty.Register("InitialDisabledValue", typeof(Brush), typeof(SwitchButton), new PropertyMetadata(default(Brush)));
      
         public SwitchButton() : base()
       {
          //Just call the base class constructor
       }
       
       public Boolean Check
       {
           get
           { return (Boolean)GetValue(CheckProperty); }

           set
           {
               SetValue(CheckProperty, value);
           }
       }



       public static void OnCheckedChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
       {
           //Checking the IsChecked property....
           Console.WriteLine("Checked value has been change..");
           SwitchButton myButton = sender as SwitchButton;
           Console.WriteLine(myButton.Check);
           if (!myButton.Check)
           {
               Console.WriteLine("Inside checked value  false..");
               myButton.EnableColor = new SolidColorBrush(Color.FromRgb(202, 202, 209));
               myButton.DisableColor = myButton.Background;
               Console.WriteLine(myButton.DisableColor);
               Console.WriteLine(myButton.EnableColor);
           }    
       
               
       }


       public Brush DisableColor
       {
           get
           {
               return (Brush)GetValue(DisableColorProperty);
           }
           set
           {
               SetValue(DisableColorProperty, value);
           }

       }


       public Brush EnableColor
       {
           get
           {
               return (Brush)GetValue(EnableColorProperty);
           }
           set
           {
               SetValue(EnableColorProperty, value);
           }

       }

       public Brush InitialEnabledValue
       {
           get
           {
               return (Brush)GetValue(InitialEnabledValueProperty);
           }
           set
           {
               SetValue(InitialEnabledValueProperty, value);
           }

       }




       public Brush InitialDisabledValue
       {
           get
           {
               return (Brush)GetValue(InitialDisabledValueProperty);
           }
           set
           {
               SetValue(InitialDisabledValueProperty, value);
           }

       }

      

   }


   class CustomPanel : StackPanel
   {
       public static DependencyProperty CheckProperty = DependencyProperty.Register("Check", typeof(Boolean), typeof(CustomPanel),new PropertyMetadata(default(Boolean), new PropertyChangedCallback(OnCheckedChanged))  );
       public static DependencyProperty DisabledProperty = DependencyProperty.Register("Disabled", typeof(Boolean), typeof(CustomPanel), new PropertyMetadata(default(Boolean)));
       public static DependencyProperty DisableColorProperty = DependencyProperty.Register("DisableColor", typeof(Brush), typeof(CustomPanel), new PropertyMetadata(default(Brush)));
       public static DependencyProperty EnableColorProperty = DependencyProperty.Register("EnableColor", typeof(Brush), typeof(CustomPanel), new PropertyMetadata(default(Brush)));
       public static DependencyProperty InitialEnabledValueProperty = DependencyProperty.Register("InitialEnabledValue", typeof(Brush), typeof(CustomPanel), new PropertyMetadata(default(Brush)));
       public static DependencyProperty InitialDisabledValueProperty = DependencyProperty.Register("InitialDisabledValue", typeof(Brush), typeof(CustomPanel), new PropertyMetadata(default(Brush)));
      
       
       
       public CustomPanel() : base()
       {
          //Just call the base class constructor
       }

       public static void OnCheckedChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
       {
           //Checking the IsChecked property....

          /* Console.WriteLine("hey i am in checked");
          
           CustomPanel stackPanel = sender as CustomPanel;
           Console.WriteLine("HEy i am getting inside Ischecked  and the value is " + stackPanel.Check);
           if (stackPanel.Check)
           {

               stackPanel.EnableColor = stackPanel.InitialEnabledValue;
               stackPanel.DisableColor = stackPanel.InitialDisabledValue;

           }
           if (stackPanel.Check == false)
           {
               Console.WriteLine("HEy i am getting inside Ischecked false");
               stackPanel.EnableColor = stackPanel.InitialDisabledValue;
               stackPanel.DisableColor = stackPanel.InitialEnabledValue;

           }
           */
           
       }

       public Boolean Check
       {
           get
           { return (Boolean)GetValue(CheckProperty); }

           set
           {
               SetValue(CheckProperty, value);
           }
       }


       
       public Brush DisableColor
       {
           get
           {
               return (Brush)GetValue(DisableColorProperty);
           }
           set
           {
               SetValue(DisableColorProperty, value);
           }

       }

       public Brush InitialEnabledValue
       {
           get
           {
               return (Brush)GetValue(InitialEnabledValueProperty);
           }
           set
           {
               SetValue(InitialEnabledValueProperty, value);
           }

       }




       public Brush InitialDisabledValue
       {
           get
           {
               return (Brush)GetValue(InitialDisabledValueProperty);
           }
           set
           {
               SetValue(InitialDisabledValueProperty, value);
           }

       }

       public Brush EnableColor
       {
           get
           {
               return (Brush)GetValue(EnableColorProperty);
           }
           set
           {
               SetValue(EnableColorProperty, value);
           }

       }


       public Boolean Disabled
       {
           get
           {
               return (Boolean)GetValue(DisabledProperty);
           }
           set
           {
               SetValue(DisabledProperty, value);
           }

       }

   }


   




}
