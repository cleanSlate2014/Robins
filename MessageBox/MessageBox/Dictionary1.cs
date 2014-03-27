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


namespace MessageBox
{
    partial class Dictionary1
    {
    }

    class MessageDialogBox : Window
    {
        public MessageDialogBox(  )
        {
            

        }

        public void Shows()
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.WindowStyle = WindowStyle.None;
            this.AllowsTransparency = true;
            this.BorderBrush = Brushes.Black;
            this.BorderThickness = new Thickness(1);
            this.ShowInTaskbar = false;
            this.MouseLeftButtonDown += DragDropSupport;
            this.Width = 350;
            this.Height = 180;
            Style gridStyle = (Style)Application.Current.FindResource("panel");
            Style headingPanel = Application.Current.FindResource("headingPanelDefault") as Style;
            Style textPanel = Application.Current.FindResource("textPanel") as Style;
            Grid gridPanel = new Grid();
            gridPanel.Style = gridStyle;
            this.ShowDialog();
        }


        private void DragDropSupport(object sender, RoutedEventArgs e)
        {
            DragMove();
        }

    }


     class CustomPanel : Grid
     {
        public CustomPanel() : base()
        {
           Style style = Application.Current.FindResource("panel") as Style;
           this.Style = style;

        }
    }



   class Title:Label
   {
       public Title()
       {
           Type = "headingPanelInfo";
           this.Loaded +=Title_Loaded;
       }

       String _Type;
       public String Type 
       {
           get { return _Type; }
           set { _Type = value; } 
       }

       private void Title_Loaded(object sender, RoutedEventArgs e)
       {  
           Style headingPanel = Application.Current.FindResource(Type) as Style;
           this.Style = headingPanel;
           this.VerticalAlignment = VerticalAlignment.Top;   
       }
   }



   class Body : Grid
   {
       public Body()
       {
           this.Loaded+=Body_Loaded;
           this.Margin = new Thickness(0, 8, 0, 0);
       }


       private void Body_Loaded(object sender, RoutedEventArgs e)
       {
            
           Border border = new Border();      
           border.Padding = new Thickness(8);
           Style borderStyle = Application.Current.FindResource("textPanelBorder") as Style;
           border.Style = borderStyle;
           CustomPanel panel = this.Parent as CustomPanel;
           try
           {
               panel.Children.Remove(this);
               border.Child = this;
               panel.Children.Add(border);
           }
           catch (Exception)
           {
               /*Do nothing */
           }
       }
   }
}
