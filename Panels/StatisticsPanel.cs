using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Data.SqlClient;
using main = IndieGameDevelopmentHubApp.Program;
using System.Windows.Forms.Design;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Windows.Forms.DataVisualization.Charting;

namespace IndieGameDevelopmentHubApp
{
    public partial class StatisticsPanel : UserControl
    {
        public StatisticsPanel()
        {
            InitializeComponent();

            //BarChart();
        }

        private void BarChart()
        { 
            var chart1 = new Chart
            {
                Dock = DockStyle.Fill
            };

            this.Controls.Add(chart1);
            // Create the chart area
            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.AxisX.Interval = 1;  // 🔧 Force showing all labels
            chart1.ChartAreas.Add(chartArea);

            // Create the bar chart series
            Series series = new Series("Sales")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            }; 
            // Add data
            series.Points.AddXY("January", 500);
            series.Points.AddXY("February", 700);
            series.Points.AddXY("March", 300);
            series.Points.AddXY("April", 800); 
            // Add the series to the chart
            chart1.Series.Add(series);

            // Optional: Chart title
            chart1.Titles.Add("Monthly Sales");

            // Optional: Axis labels
            chart1.ChartAreas[0].AxisX.Title = "Month";
            chart1.ChartAreas[0].AxisY.Title = "Sales (USD)";
        }
        private void PieChart() 
        {

            Chart? chart1 = new Chart
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(chart1);

            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            series.Points.AddXY("Apples", 30);
            series.Points.AddXY("Bananas", 20);
            series.Points.AddXY("Cherries", 25);
            series.Points.AddXY("Dates", 25);

            chart1.Series.Add(series);
            chart1.Titles.Add("Fruit Consumption");
           // this.BugReportsBarChart.Controls.Add(chart1);
        }

    }
}
