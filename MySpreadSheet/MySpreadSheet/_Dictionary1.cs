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


namespace MySpreadSheet
{
    partial class _Dictionary1
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

    }


     class MessageDialogBox : Window
     {

        Grid gridPanel;
        Border border;

        /*Declaring standard values */
        private const Int32 OK = 5100, OKCANCEL = 5101, YESNO = 5102, YESNOCANCEL = 5103;
        public Boolean Ok = false, Cancel = false, Yes = false, No = false;

        public MessageDialogBox(String body, String title = "", Int32 type = OK)
        {
            //Adding a leftbutton down event to window..for closing of box on click..
            this.MouseLeftButtonDown +=MessageDialogBox_MouseLeftButtonDown;
            Body = body;
            _Title = title;
            Type = type;
            
        }

        public void Display()
        {

           


            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.WindowStyle = WindowStyle.None;
            this.AllowsTransparency = true;
            this.BorderBrush = Brushes.Black;
            this.BorderThickness = new Thickness(1);
            this.ShowInTaskbar = false;
            this.WindowState = WindowState.Maximized;
            this.Background = Brushes.White;
            this.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            this.Background.Opacity = 0.01;
            this.MouseLeftButtonDown += DragDropSupport;
            border = new Border();
            border.BorderBrush = Brushes.Black;
            border.BorderThickness = new Thickness(1);
            gridPanel = new Grid();
           

            border.Child = gridPanel;
           
            border.Width = 350;
            border.Height = 250;
            gridPanel.Background = Brushes.White;
            MessageBoxFactory(Body, _Title, Type);
            
            this.AddChild(border);
            this.ShowDialog();
        }

        private String _body;
        private String Body
        {
            get { return _body; }
            set { _body = value; }
        }


        private String _title;
        private String _Title
        {
            get { return _title; }
            set { _title = value; }
        }


        private Int32 _type;
        private Int32 Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private void MessageBoxFactory(String body, String title = "", Int32 type = OK)
        {
           
            if (String.IsNullOrEmpty(title) == false)
            {
                Label label = new Label();
                Style style = Application.Current.FindResource("h3") as Style;
                label.Style = style;
                label.Content = title;
                label.HorizontalAlignment = HorizontalAlignment.Center;
                label.Padding = new Thickness(15, 10, 15, 10);
                //Adding grid child..
                gridPanel.Children.Add(label);
                Console.WriteLine(label.Content);

            }

            Grid grid = new Grid();
            FlowDocumentScrollViewer flowDocumentScrollViewer = new FlowDocumentScrollViewer();
            flowDocumentScrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
            flowDocumentScrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            flowDocumentScrollViewer.IsToolBarVisible = false;
            flowDocumentScrollViewer.Padding = new Thickness(15, 35, 15, 10);
            FlowDocument flowDocument = new FlowDocument();
            Paragraph paragraph = new Paragraph( new Run(body) );
            Style Parastyle =  Application.Current.FindResource("parah5") as Style;
            paragraph.Style = Parastyle;
            flowDocument.Blocks.Add(paragraph);
            flowDocumentScrollViewer.Document = flowDocument;
      
            grid.Children.Add(flowDocumentScrollViewer);
            gridPanel.Children.Add(grid);


            //declaring a button grid..
            Grid btnGrid = new Grid();

            //Definging three buttons and their event..
            Button btnOk = new Button();
            btnOk.Click +=btnOk_Click;

            Button btnCancel = new Button();
            btnCancel.Click +=btnCancel_Click;


            Button btnYes = new Button();
            btnYes.Click +=btnYes_Click;

            Button btnNo = new Button();
            btnNo.Click += btnNo_Click;

            StackPanel btnPanel = new StackPanel();
            btnPanel.Height = 40;
            btnPanel.Margin = new Thickness(0, 0, 0, 20);
            btnPanel.Background = Brushes.Red;
            btnPanel.VerticalAlignment = VerticalAlignment.Bottom;
            btnPanel.Orientation = Orientation.Horizontal;

            if (Type == OK)
            {

                btnOk.Width = 80;
                btnOk.Height = 40;
                btnOk.Content = "OK";
                btnPanel.Children.Add(btnOk);
                btnPanel.HorizontalAlignment = HorizontalAlignment.Center;
                gridPanel.Children.Add(btnPanel);
                
            }

        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            //Setting the value..
            Ok = true;
            //Now closing window..
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Cancel = true;
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            Yes = true;
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            No = true;
        }


      
    
        private void MessageDialogBox_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            if (this.border.IsMouseOver == false)
            {
                this.Close();
                Console.WriteLine("i am getting closed");
            }

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
