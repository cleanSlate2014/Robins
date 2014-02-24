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

namespace WpfApplication21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            /*Style style = new Style { TargetType = typeof(Rectangle) };
            style.Setters.Add(new Setter(Rectangle.FillProperty, Brushes.Red)); */

            //Application.Current.Resources["rob"] = style;
            InitializeComponent();
            //Style style = Application.Current.Resources["button_style"] as Style;
            Style style = this.Resources["button_style"] as Style;
            Console.WriteLine("hi");
            Style new_style = new Style();
            new_style.BasedOn = style;
            new_style.TargetType = typeof(Button);
            new_style.Setters.Add(new Setter(Button.BackgroundProperty, Brushes.Blue));
            ControlTemplate test = this.Resources["test"] as ControlTemplate;
            
            
           
           
           
        }

        private void Grid_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            
            
        }
          /// <summary>
        /// Finds a Child of a given item in the visual tree. 
        /// </summary>
        /// <param name="parent">A direct parent of the queried item.</param>
        /// <typeparam name="T">The type of the queried item.</typeparam>
        /// <param name="childName">x:Name or Name of child. </param>
        /// <returns>The first parent item that matches the submitted type parameter. 
        /// If not matching item can be found, 
        /// a null parent is being returned.</returns>
        public static T FindChild<T>(DependencyObject parent, string childName)
           where T : DependencyObject
        {
            // Confirm parent and childName are valid. 
            if (parent == null) return null;

            T foundChild = null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                // If the child is not of the request child type child
                T childType = child as T;
                if (childType == null)
                {
                    // recursively drill down the tree
                    foundChild = FindChild<T>(child, childName);

                    // If the child is found, break so we do not overwrite the found child. 
                    if (foundChild != null) break;
                }
                else if (!string.IsNullOrEmpty(childName))
                {
                    var frameworkElement = child as FrameworkElement;
                    // If the child's name is set for search
                    if (frameworkElement != null && frameworkElement.Name == childName)
                    {
                        // if the child's name is of the request name
                        foundChild = (T)child;
                        break;
                    }
                }
                else
                {
                    // child element found.
                    foundChild = (T)child;
                    break;
                }
            }

            return foundChild;
        }
        
    

        private void r_Click_1(object sender, RoutedEventArgs e)
        {
            Style style = App.Current.Resources["button_style"] as Style;
            
            Style new_style = new Style();
            new_style.BasedOn = style;
            new_style.TargetType = typeof(Button);
            new_style.Setters.Add(new Setter(Button.BackgroundProperty, Brushes.Black));
            Button btn = FindChild<Button>(Application.Current.MainWindow, "xxx") as Button;
            //ControlTemplate template = App.Current.Resources["test"] as ControlTemplate;
            btn.Content = ;
           
            Console.WriteLine(btn.Content);
            //foundbtn.Style = new_style;
            
            
        }
    }
}
