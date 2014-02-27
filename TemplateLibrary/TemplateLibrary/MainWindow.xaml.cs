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
using x = System.Windows.Forms;


namespace TemplateLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine(((Color)xxx.Background.GetValue(SolidColorBrush.ColorProperty)).A+"\n");
            Console.WriteLine(((Color)xxx.Background.GetValue(SolidColorBrush.ColorProperty)).B);
            Console.WriteLine(((Color)xxx.Background.GetValue(SolidColorBrush.ColorProperty)).G);
            Colorpicker my_color = new Colorpicker(xxx.Background);
            Console.WriteLine(((Color)my_color.lighter().GetValue(SolidColorBrush.ColorProperty)).B);
            Console.WriteLine(((Color)my_color.lighter().GetValue(SolidColorBrush.ColorProperty)).G);
            Console.WriteLine(((Color)my_color.lighter().GetValue(SolidColorBrush.ColorProperty)).R);
            xxx.Background = my_color.lighter();
            Console.WriteLine(((Color)xxx.Background.GetValue(SolidColorBrush.ColorProperty)).B);
            Console.WriteLine(((Color)xxx.Background.GetValue(SolidColorBrush.ColorProperty)).G);

        }
    }



    #region Class Of Color Start Here
    class Colorpicker
    {
        Byte a, g, r, b, colorFactor;
            String identifier;

            //Class for lightening or darkening the color..
            public Colorpicker(Brush color)
            {

                a = ((Color)color.GetValue(SolidColorBrush.ColorProperty)).A;
                g = ((Color)color.GetValue(SolidColorBrush.ColorProperty)).G;
                r = ((Color)color.GetValue(SolidColorBrush.ColorProperty)).R;
                b = ((Color)color.GetValue(SolidColorBrush.ColorProperty)).B;


            }
            public Brush light()
            {

                colorFactor = (Byte)15;
                identifier = "Light";
                return colorFactory(colorFactor, identifier);
            }
            public Brush lighter()
            {
                colorFactor = (Byte)30;
                identifier = "Lighter";
                return colorFactory(colorFactor, identifier);
            }
            public Brush dark()
            {
                colorFactor = (Byte)15;
                identifier = "Dark";
                return colorFactory(colorFactor, identifier);
            }
            public Brush darker()
            {
                colorFactor = (Byte)30;
                identifier = "Darker";
                return colorFactory(colorFactor, identifier);
            }

            //Factory for adjusting color
            private Brush colorFactory(Byte colorFactor, string identifier)
            {


                if (identifier == "Light" || identifier == "Lighter")
                {
                    if (r > (Byte)240 && g > (Byte)240 && b > (Byte)240)
                    {
                        r = g = b = (Byte)255;
                        //return value
                    }
                    else if (r > (Byte)240 || g > (Byte)240 || b > (Byte)240)
                    {
                        if (r > (Byte)240)
                        {
                            r = (Byte)255;

                        }
                        if (g > (Byte)240)
                        {
                            g = (Byte)255;

                        }
                        if (b > (Byte)240)
                        {
                            b = (Byte)255;

                        }
                    }
                }//IF for identifier closed
                else
                {
                    //For dark color
                    if (r < (Byte)15 && g < (Byte)15 && b < (Byte)15)
                    {
                        r = g = b = (Byte)0;
                        //return value

                    }
                    else if (r < (Byte)15 || g < (Byte)15 || b < (Byte)15)
                    {
                        if (r < (Byte)15)
                        {
                            r = (Byte)0;

                        }
                        if (g < (Byte)15)
                        {
                            g = (Byte)0;

                        }
                        if (b < (Byte)15)
                        {
                            b = (Byte)0;
                        }

                    }

                }
                //Now pass the value to subfactory
                colorSubFactory(r, g, b, identifier);
                return colorSubFactory(r, g, b, identifier);
            }


            //ColorSubFactory method for further implementing the color class..
            private Brush colorSubFactory(Byte r, Byte g, Byte b, String identifier)
            {
                Brush newColor;
                if (identifier == "Light" || identifier == "Lighter")
                {
                    if (r < (Byte)255)
                    {
                        r = AdjustColor(r, identifier);
                    }
                    if (g < (Byte)255)
                    {
                        g = AdjustColor(g, identifier);
                    }
                    if (b < (Byte)255)
                    {
                        b = AdjustColor(b, identifier);
                    }

                }
                else
                {
                    //For darker value..
                    if (r > (Byte)0)
                    {
                        r = AdjustColor(r, identifier);
                    }
                    if (g > (Byte)0)
                    {
                        g = AdjustColor(g, identifier);
                    }
                    if (b > (Byte)0)
                    {
                        b = AdjustColor(b, identifier);
                    }

                }
                //Now returning color
                Color adjustedColor = Color.FromArgb(a, r, g, b);
                newColor = new SolidColorBrush(adjustedColor);
                return newColor;
            }



            private Byte AdjustColor(Byte value, String identifier)
            {
                Byte colorFactor = (Byte)15;
                //For storing temp values..
                int temp;
                
                 //Increment all value and then return
                    if (identifier == "Light")
                    {
                        temp = value + colorFactor;
                        value = (Byte)temp;

                    }
                    else if (identifier == "Lighter")
                    {
                        if( value <= (Byte)225)
                        {
                            colorFactor = (Byte)30;
                            temp = value + colorFactor;
                            value = (Byte)temp;
                        }
                        else {temp = (Byte)225; value = (Byte)temp;};
                    }

                    else if (identifier == "Dark")
                    {
                 
                        temp = value - colorFactor;
                        value = (Byte)temp;

                    }
                    else if (identifier == "Darker")
                    {
                        if (value >= (Byte)30)
                        {
                            colorFactor = (Byte)30;
                            temp = value - colorFactor;
                            value = (Byte)temp;
                        }
                        else { temp = (Byte)0; value = (Byte)temp; };
                    }  
  
                //Now return new_byte value
                return value;
            }


    } //ColorPicker class ends here
    #endregion //Region ends for color picker

}
    

