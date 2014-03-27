using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Charting;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.ChartView;

namespace TelerikWpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RadCartesianChart chart = new RadCartesianChart();
            CategoricalAxis catAxis = new CategoricalAxis();
            LinearAxis lineAxis = new LinearAxis();
            chart.HorizontalAxis = catAxis;
            chart.VerticalAxis = lineAxis;
            ChartPanAndZoomBehavior c = new ChartPanAndZoomBehavior();
            c.ZoomMode = ChartPanZoomMode.Both;
            c.PanMode = ChartPanZoomMode.Both;
            chart.Behaviors.Add(c);
            LineSeries barSeries = new LineSeries();
            barSeries.DataPoints.Add(new CategoricalDataPoint() { Category = "Apples", Value = 2 });
            barSeries.DataPoints.Add(new CategoricalDataPoint() { Category = "Bananas", Value = 28 });
            barSeries.DataPoints.Add(new CategoricalDataPoint() { Category = "Oranges", Value = 17 });
            barSeries.DataPoints.Add(new CategoricalDataPoint() { Category = "Strawberries", Value = 30 });
    
            chart.Series.Add(barSeries);
            G.Children.Add(chart);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
