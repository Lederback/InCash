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
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace GestaoFinanceira
{
    /// <summary>
    /// Lógica interna para Overview.xaml
    /// </summary>
    public partial class Overview : Window
    {
        public Overview()
        {
            InitializeComponent();
            PieChart();
            Doughnut();

            doughnut.ToolTip = null;
            doughnut.DataTooltip = null;
            doughnut.Hoverable = false;
        }

        public void PieChart()
        {
            PointLabel = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataContext = this;
        }

        public void Doughnut()
        {
            seriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title="Lazer",
                    Values = new ChartValues<ObservableValue> {new ObservableValue(5)},
                    DataLabels = true,
                    Stroke = null,
                    StrokeThickness = 0,
                    Fill = Brushes.Black,
                },
                new PieSeries
                {
                    Title="Contas",
                    Values = new ChartValues<ObservableValue> {new ObservableValue(8)},
                    DataLabels = true,
                    Stroke = null,
                    StrokeThickness = 0,
                },
                new PieSeries
                {
                    Title="Alimentação",
                    Values = new ChartValues<ObservableValue> {new ObservableValue(4)},
                    DataLabels = true,
                    Stroke = null,
                    StrokeThickness = 0,
                },
            };

            DataContext = this;
        }

        public Func<ChartPoint, string> PointLabel { get; set; }
        public SeriesCollection seriesCollection { get; set; }

        private void MenuButton_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Button).Foreground = Brushes.Black;
        }

        private void MenuButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#FFFFFF");
            Brush brush = new SolidColorBrush(color);
            (sender as Button).Foreground = brush;
        }
    }
}
