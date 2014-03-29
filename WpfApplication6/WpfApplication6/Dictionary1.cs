using System;
using System.IO;
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
using System.Text.RegularExpressions;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CustomControlsLibrary;
using System.Globalization;
using System.Drawing.Imaging;
using drawing = System.Drawing;

namespace WpfApplication6
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

    }




    class MessageDialogBox : Window
    {

        Grid gridPanel;
        Border border;
        ImageSource IconSource;
        Image IconImage;

        /*Declaring standard values */
        public static  Int32 OK = 5100, OKCANCEL = 5101, YESNO = 5102, YESNOCANCEL = 5103, NONE = 5104;
        public Boolean Ok = false, Cancel = false, Yes = false, No = false;
        private const Int32 defaultOk = 5100;

        public static Int32
            App = 1,
            Exclamation = 2,
            Error = 3,
            Warning = 4,
            Info = 5,
            Question = 6,
            Shield = 7,
            Search = 8; 

        #region  CONSTRUCTOR

            public MessageDialogBox()
            {
                //Adding a leftbutton down event to window..for closing of box on click..
                this.MouseLeftButtonDown += MessageDialogBox_MouseLeftButtonDown;
            
                gridPanel = new Grid();
                //Defigning the grid definition..
                RowDefinition rowDef1 = new RowDefinition();
                rowDef1.Height = GridLength.Auto;
                gridPanel.RowDefinitions.Add(rowDef1);

                RowDefinition rowDef2 = new RowDefinition();
                rowDef2.Height = new  GridLength(1,GridUnitType.Star);
                gridPanel.RowDefinitions.Add(rowDef2);
               
                 RowDefinition rowDef3 = new RowDefinition();
                 rowDef3.Height = new GridLength(2, GridUnitType.Auto);
                 gridPanel.RowDefinitions.Add(rowDef3);
               
            }


            public MessageDialogBox(String body, String title, Int32 iconType, Int32 type = defaultOk)
            {
                //Adding a leftbutton down event to window..for closing of box on click..
                this.MouseLeftButtonDown += MessageDialogBox_MouseLeftButtonDown;
                Body = body;
                Title = title;
                Type = type;
                //Setting the IconSource...
                SetIcon(iconType);
                Console.WriteLine(IconSource.GetType().ToString());
                IconImage = new Image();
                //Now setting the IconImage
                IconImage.Source = (ImageSource)IconSource;

                gridPanel = new Grid();
                //Defigning the grid definition..
            
                RowDefinition rowDef1 = new RowDefinition();
                rowDef1.Height = GridLength.Auto;
                gridPanel.RowDefinitions.Add(rowDef1);
              

                RowDefinition rowDef2 = new RowDefinition();
                rowDef2.Height = new GridLength(1, GridUnitType.Star);
                gridPanel.RowDefinitions.Add(rowDef2);
               
                RowDefinition rowDef3 = new RowDefinition();
                rowDef3.Height = new GridLength(2, GridUnitType.Auto);
                gridPanel.RowDefinitions.Add(rowDef3);

                //Defigning columns....
                ColumnDefinition colDef1 = new ColumnDefinition();
                colDef1.Width = GridLength.Auto;
                gridPanel.ColumnDefinitions.Add(colDef1);

                ColumnDefinition colDef2 = new ColumnDefinition();
                colDef2.Width = new GridLength(1, GridUnitType.Star);
                gridPanel.ColumnDefinitions.Add(colDef2);


             
            }


            public MessageDialogBox(String body, Int32 type = defaultOk)
            {
                //Adding a leftbutton down event to window..for closing of box on click..
                this.MouseLeftButtonDown += MessageDialogBox_MouseLeftButtonDown;
                Body = body;
                Type = type;

                gridPanel = new Grid();
                //Defigning the grid definition..

                RowDefinition rowDef1 = new RowDefinition();
                rowDef1.Height = GridLength.Auto;
                gridPanel.RowDefinitions.Add(rowDef1);


                RowDefinition rowDef2 = new RowDefinition();
                rowDef2.Height = new GridLength(1, GridUnitType.Star);
                gridPanel.RowDefinitions.Add(rowDef2);

                RowDefinition rowDef3 = new RowDefinition();
                rowDef3.Height = new GridLength(2, GridUnitType.Auto);
                gridPanel.RowDefinitions.Add(rowDef3);

            }


            public MessageDialogBox(String body, String title,  Int32 type = defaultOk)
            {
                //Adding a leftbutton down event to window..for closing of box on click..
                this.MouseLeftButtonDown += MessageDialogBox_MouseLeftButtonDown;
                Body = body;
                Title = title;
                Type = type;
               

                gridPanel = new Grid();
                //Defigning the grid definition..

                RowDefinition rowDef1 = new RowDefinition();
                rowDef1.Height = GridLength.Auto;
                gridPanel.RowDefinitions.Add(rowDef1);


                RowDefinition rowDef2 = new RowDefinition();
                rowDef2.Height = new GridLength(1, GridUnitType.Star);
                gridPanel.RowDefinitions.Add(rowDef2);

                RowDefinition rowDef3 = new RowDefinition();
                rowDef3.Height = new GridLength(2, GridUnitType.Auto);
                gridPanel.RowDefinitions.Add(rowDef3);

            }

        #endregion


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
                
                border.HorizontalAlignment = HorizontalAlignment.Center;
                border.BorderThickness = new Thickness(1);
                border.Child = gridPanel;
                Size MessageBoxSize = MessageSize(Body);
                border.Width = MessageBoxSize.Width;
                border.Height = MessageBoxSize.Height;
                gridPanel.Background = Brushes.White;
                
                MessageBoxFactory();
                this.AddChild(border);
                this.ShowDialog();
           }

        private String _body;
        public String Body
        {
            get { return _body; }
            set { _body = value; }
        }


        private String _title="";
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }


        private Int32 _type = defaultOk;
        public Int32 Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private Double _width = 390;
        public Double Width
        {
            get { return _width; }
            set { _width = value; }
        }



        private Double _height = 250;
        public Double Height
        {
            get { return _height; }
            set { _height = value; }
        }


        private Boolean _clickDisable = false;
        public Boolean ClickDisable
        {
            get { return _clickDisable; }
            set { _clickDisable = value; }
        }


        private Int32 _iconType;
        public Int32 IconType
        {
            get { return _iconType; }
            set { _iconType = value; }

        }

     

        private void MessageBoxFactory()
        {

            if (String.IsNullOrEmpty(Title) == false)
            {
                Label label = new Label();
                Style style = Application.Current.FindResource("h4") as Style;
                label.Style = style;
                label.Content = Title;
                label.HorizontalAlignment = HorizontalAlignment.Center;
                label.Padding = new Thickness(15, 10, 15, 10);
                label.VerticalAlignment = VerticalAlignment.Top;
                gridPanel.Children.Add(label);
              

            }



            Grid grid = new Grid();
            FlowDocumentScrollViewer flowDocumentScrollViewer = new FlowDocumentScrollViewer();
            flowDocumentScrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
            flowDocumentScrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            flowDocumentScrollViewer.IsToolBarVisible = false;
            if (String.IsNullOrEmpty(Title) == true)
            {
                flowDocumentScrollViewer.Padding = new Thickness(15, 15, 15, 10);
            }
            else
            {
                flowDocumentScrollViewer.Padding = new Thickness(15, 35, 15, 10);
            }
            FlowDocument flowDocument = new FlowDocument();
            flowDocument.FontFamily = new FontFamily("Segoe UI");
            flowDocument.FontSize = 10;

            Paragraph paragraph;
            try
            {
               
                IconImage.Height = 26;
                IconImage.Width = 26;
                Grid ImageGrid = new Grid();
                //ImageGrid.Background = Brushes.Red;
                ImageGrid.Width = 50;
                //ImageGrid.Margin = new Thickness(40);
                ImageGrid.Children.Add(IconImage);
                //ImageGrid.SetValue(Grid.ColumnProperty, 0);
                ImageGrid.HorizontalAlignment = HorizontalAlignment.Left;
                //ImageGrid.VerticalAlignment = VerticalAlignment.Top;
                grid.Children.Add(ImageGrid);

                //InlineUIContainer inlineUiContainer = new InlineUIContainer(IconImage);
                //Span span = new Span(inlineUiContainer);
                //span.Inlines.Add(new Run(Body));
                
                paragraph = new Paragraph(new Run(Body));
                paragraph.Margin = new Thickness(70);
            }
            catch (Exception)
            {
                 Console.WriteLine("I am getting exceptions in image");
                 paragraph = new Paragraph(new Run( Body ));

            }
            
            
            
            Style Parastyle = Application.Current.FindResource("parah4") as Style;
            paragraph.Style = Parastyle;
            

            

            flowDocument.Blocks.Add(paragraph);
           

            flowDocumentScrollViewer.Document = flowDocument;
            grid.Children.Add(flowDocumentScrollViewer);
            //grid.SetValue(Grid.ColumnProperty, 1);
            gridPanel.Children.Add(grid);


            //declaring a button grid..
            Grid btnGrid = new Grid();
            //Definging three buttons and their event..
            Button btnOk = new Button();
            btnOk.Click += btnOk_Click;
            Button btnCancel = new Button();
            btnCancel.Click += btnCancel_Click;


            Button btnYes = new Button();
            btnYes.Click += btnYes_Click;

            Button btnNo = new Button();
            btnNo.Click += btnNo_Click;

            StackPanel btnPanel = new StackPanel();
            Grid.SetRow(btnPanel, 2);
            btnPanel.Height = 40;
            btnPanel.Margin = new Thickness(35, 0, 35, 15);
            btnPanel.Orientation = Orientation.Horizontal;
            if (Type == OK)
            {

                btnOk.Width = 80;
                //btnOk.Height = 30;
                btnOk.Content = "OK";
                btnOk.Margin = new Thickness(10,0,10,0);
                btnPanel.Children.Add(btnOk);
                btnPanel.HorizontalAlignment = HorizontalAlignment.Center;
                
                
                gridPanel.Children.Add(btnPanel);

            }

            if (Type == OKCANCEL)
            {

                btnOk.Width = 80;
                
                btnOk.Content = "OK";

                btnCancel.Width = 80;
                
                btnCancel.Content = "Cancel";
                btnCancel.Margin = new Thickness(20, 0, 0, 0);

                btnPanel.Children.Add(btnOk);
                btnPanel.Children.Add(btnCancel);
                btnPanel.HorizontalAlignment = HorizontalAlignment.Center;

                gridPanel.Children.Add(btnPanel);

            }

            if (Type == YESNO)
            {

                btnYes.Width = 80;
                
                btnYes.Content = "Yes";
               

                btnNo.Width = 80;
                
                btnNo.Content = "No";
                btnNo.Margin = new Thickness(20, 0, 0, 0);
               

                btnPanel.Children.Add(btnYes);
                btnPanel.Children.Add(btnNo);
                btnPanel.HorizontalAlignment = HorizontalAlignment.Center;
                gridPanel.Children.Add(btnPanel);

            }

            if (Type == YESNOCANCEL)
            {

                btnYes.Width = 80;
                
                btnYes.Content = "Yes";


                btnNo.Width = 80;
                
                btnNo.Content = "No";
                btnNo.Margin = new Thickness(10, 0, 0, 0);
                btnNo.HorizontalAlignment = HorizontalAlignment.Center;
                btnCancel.Width = 80;
               
                btnCancel.Content = "Cancel";
                btnCancel.Margin = new Thickness(56, 0, 0, 0);
                btnCancel.HorizontalAlignment =  HorizontalAlignment.Right;

                btnPanel.Children.Add(btnYes);
                btnPanel.Children.Add(btnNo);
                btnPanel.Children.Add(btnCancel);

                gridPanel.Children.Add(btnPanel);

            }

            if (Type == NONE)
            {
                

            }

        }


        

        #region FOR GETTING  WINDOWS ICONS

        private  void SetIcon(Int32 icon)
        {


            drawing.Bitmap bitmap;
            if (icon == App)
            {
                bitmap = System.Drawing.SystemIcons.Application.ToBitmap();
                using (MemoryStream memory = new MemoryStream())
                {
                    
                    bitmap.Save(memory, ImageFormat.Png);
                    memory.Position = 0;
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = memory;
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.EndInit();
                    IconSource = bitmapImage;
                }

                
              
            }
            else if(icon == Exclamation)
            {
                   
                    bitmap =  System.Drawing.SystemIcons.Exclamation.ToBitmap();
                    using (MemoryStream memory = new MemoryStream())
                    {

                        bitmap.Save(memory, ImageFormat.Png);
                        memory.Position = 0;
                        BitmapImage bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.StreamSource = memory;
                        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                        bitmapImage.EndInit();
                        IconSource = bitmapImage;
                    }

                    
            }
            else if(icon == Error)
            {
               
                     bitmap =  System.Drawing.SystemIcons.Error.ToBitmap();
                     using (MemoryStream memory = new MemoryStream())
                     {

                         bitmap.Save(memory, ImageFormat.Png);
                         memory.Position = 0;
                         BitmapImage bitmapImage = new BitmapImage();
                         bitmapImage.BeginInit();
                         bitmapImage.StreamSource = memory;
                         bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                         bitmapImage.EndInit();
                         IconSource = bitmapImage;
                     }

                   
            }
            else if(icon == Info)
            {
             
                    bitmap = System.Drawing.SystemIcons.Information.ToBitmap();
                    using (MemoryStream memory = new MemoryStream())
                    {

                        bitmap.Save(memory, ImageFormat.Png);
                        memory.Position = 0;
                        BitmapImage bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.StreamSource = memory;
                        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                        bitmapImage.EndInit();
                        IconSource = bitmapImage;
                    }

             
            }
            else if(icon == Question)
            {
                
                     bitmap =  System.Drawing.SystemIcons.Question.ToBitmap();
                     using (MemoryStream memory = new MemoryStream())
                     {

                         bitmap.Save(memory, ImageFormat.Png);
                         memory.Position = 0;
                         BitmapImage bitmapImage = new BitmapImage();
                         bitmapImage.BeginInit();
                         bitmapImage.StreamSource = memory;
                         bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                         bitmapImage.EndInit();
                         IconSource = bitmapImage;
                     }

            }
            else if(icon == Shield)
            {
                
                    bitmap =  System.Drawing.SystemIcons.Shield.ToBitmap();
                    using (MemoryStream memory = new MemoryStream())
                    {

                        bitmap.Save(memory, ImageFormat.Png);
                        memory.Position = 0;
                        BitmapImage bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.StreamSource = memory;
                        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                        bitmapImage.EndInit();
                        IconSource = bitmapImage;
                    }

                   
            }
            else if(icon == Warning)
            {
                
                    bitmap =  System.Drawing.SystemIcons.Warning.ToBitmap();
                    using (MemoryStream memory = new MemoryStream())
                    {

                        bitmap.Save(memory, ImageFormat.Png);
                        memory.Position = 0;
                        BitmapImage bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.StreamSource = memory;
                        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                        bitmapImage.EndInit();
                        IconSource = bitmapImage;
                    }

                   
            }
        }

       
      

        
       

        #endregion

        #region CALCULATING MESSAGE-BOX AUTO SIZE

        //Method for calculating the Width and Height of String
            private  Size MeasureString(string Data)
            {
                var formattedText = new FormattedText(
                    Data,
                    CultureInfo.CurrentUICulture,
                    FlowDirection.LeftToRight,
                    new Typeface(new FontFamily("Segoe UI"), FontStyles.Normal, FontWeights.Normal, FontStretches.Normal),
                    10,
                    Brushes.Black);

                return new Size(formattedText.Width, formattedText.Height);
             }

            //For getting the actual size of the Box
            private  Size MessageSize(string message)
            {
           

                Size PreferredSize = MeasureString(message);
                if (message.Length < 150)
                {
                    Width = 320;
                    Height = 180;
                }
                else if (message.Length < 270)
                {
                    Width = 390;
                    Height = 250;
                }
                else if (message.Length > 270 && message.Length < 400)
                {
                    Console.WriteLine("I am inside width >270");
                    Width = 420;
                    Height = 280;
                }
                else if (message.Length > 400 && message.Length < 560)
                {
                
                    Width = 470;
                    string[] groups = (from Match m in Regex.Matches(message, ".{1,180}") select m.Value).ToArray();
                    int lines = groups.Length + 1;
                    Height += (int)(PreferredSize.Height + 10) * lines;
                }
                else if (message.Length > 560  && message.Length < 810)
                {
                
                    Width = 520;
                    string[] groups = (from Match m in Regex.Matches(message, ".{1,180}") select m.Value).ToArray();
                    int lines = groups.Length+1;
                    Height += (int)(PreferredSize.Height +10) * lines;
                }
                else
                {
                    string[] groups = (from Match m in Regex.Matches(message, ".{1,180}") select m.Value).ToArray();
                    int lines = groups.Length + 1;
                    Width = 700;
                    Height += (int)(PreferredSize.Height + 10) * lines;
                }
          
                return new Size(Width, Height);
            }

        #endregion


        #region EVENTS
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
            //Now closing window..
            this.Close();
        }

            private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            Yes = true;
            //Now closing window..
            this.Close();
        }

            private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            No = true;
            //Now closing window..
            this.Close();
        }

            private void MessageDialogBox_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            if (this.border.IsMouseOver == false && (ClickDisable == false || Type == NONE) )
            {
                this.Close();
                Console.WriteLine("i am getting closed");
            }

        }

            private void DragDropSupport(object sender, RoutedEventArgs e)
        {
            DragMove();
        }

        #endregion

    }


    #region CUSTOM PANEL CLASS
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
           //border.VerticalAlignment = VerticalAlignment.Bottom;
             
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


    #endregion
}
