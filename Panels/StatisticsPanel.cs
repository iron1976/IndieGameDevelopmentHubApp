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

            BarChart();
            PieChart();

            SetLabelStatistics();
        }
        public static string Truncate(string text, int maxLength)
        {
            if (string.IsNullOrEmpty(text)) return text;
            return text.Length > maxLength ? text.Substring(0, maxLength) : text;
        }
        private void SetLabelStatistics()
        {
            //LINQ USAGE:
            main.SQLAccess(x =>
            {
                {
                    //LINQ USAGE:
                    var financeDatum = x.DeveloperFinances?
                      .AsEnumerable() 
                      .OrderBy(df => df.Income)
                      .GroupBy(df => df.Income)
                      .LastOrDefault()?
                      .FirstOrDefault();

                    if(financeDatum == null)
                    {
                        TopEarnerDeveloperResultText.Text = "No developers found";
                        TopEarnerDeveloperResultPointsText.Text = $"Yearly\r\nN/A$";
                        return;
                    }

                    //LINQ USAGE:
                    var foundDew = financeDatum != null
                        ? x.Developers.FirstOrDefault(dev => dev.DevId == financeDatum.DevId)
                        : null; 

                    TopEarnerDeveloperResultText.Text = foundDew.FirstName + foundDew.LastName;
                    TopEarnerDeveloperResultPointsText.Text = $"Yearly\r\n{Truncate(financeDatum.Income.ToString(), 6)}$";
                }


                {
                    //LINQ USAGE:
                    var ratingDatum = x.Games?
                        .AsEnumerable() 
                        .OrderBy(df => df.GameRating)
                        .GroupBy(df => df.GameRating)
                        .LastOrDefault()?
                        .FirstOrDefault();

                    if(ratingDatum == null)
                    {
                        TopRatedGameResultText.Text = "No games found";
                        TopRatedGameResultPointsText.Text = "N/A";
                        TopRatedGameResultProgressBar.Value = 0;
                        return;
                    }   

                    TopRatedGameResultText.Text = ratingDatum.Title;
                    TopRatedGameResultPointsText.Text = $"{ratingDatum.GameRating}/5";
                    TopRatedGameResultProgressBar.Value = (int)(10 * ratingDatum.GameRating);
                }
                {

                    //LINQ USAGE:
                    var gameWithLeastBugs = x.Games
                    .GroupJoin(
                        x.BugReports,
                        game => game.GameId,
                        bug => bug.GameId,
                        (game, bugs) => new
                        {
                            Game = game,
                            BugCount = bugs.Count()
                        }
                    )
                    .OrderBy(g => g.BugCount)
                    .FirstOrDefault();

                    if (gameWithLeastBugs == null)
                    {
                        TopEarnerDeveloperResultText.Text = "No game found";
                        TopEarnerDeveloperResultPointsText.Text = $"Yearly\r\nN/A$";
                        return;
                    }
                     

                    TopStableGameResultText.Text = gameWithLeastBugs.Game.Title;
                    TopStableGameResultPointsText.Text = $"Has {gameWithLeastBugs.BugCount} \r\nBug Reports";
                }

            });
            
        }
        private void PieChart() 
        { 
            var chart1 = new Chart
            {
                Size = new Size(500, 500),
                Location = new Point(450, 82),
                Palette = ChartColorPalette.Excel,
                BackColor = main.HomeScreen.Panel.BackColor,
                BackSecondaryColor = main.HomeScreen.Panel.BackColor,
                BorderColor = main.HomeScreen.Panel.BackColor
            };

            // Chart area
            var chartArea = new ChartArea
            {
                Name ="PieArea",
                BackColor = main.HomeScreen.Panel.BackColor,
                BackSecondaryColor = main.HomeScreen.Panel.BackColor,
                BorderColor = main.HomeScreen.Panel.BackColor 
            };
            chart1.ChartAreas.Add(chartArea);

            // Legend
            var legend = new Legend("DefaultLegend")
            {
                Docking = Docking.Right,
                Alignment = StringAlignment.Center,
                LegendStyle = LegendStyle.Table,
                Font = new Font("Segoe UI", 10),
                IsDockedInsideChartArea = false,
                BackColor = main.HomeScreen.Panel.BackColor,
                BackSecondaryColor = main.HomeScreen.Panel.BackColor,
                BorderColor = main.HomeScreen.Panel.BackColor

            };
            chart1.Legends.Add(legend);

            // Series
            var series = new Series("Genres")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Legend = "DefaultLegend"
            };
            main.SQLAccess(x =>
            {
                //LINQ USAGE:
                var genreCounts = x.GameGenres
                .GroupBy(g => g.Genre)
                .Select(g => new
                {
                    Genre = g.Key,
                    GameCount = g.Count()
                })
                .ToList();
                for (int j = 0; j < genreCounts.Count; j++)
                {
                    var dpTemp = new DataPoint { YValues = new double[] { genreCounts[j].GameCount }, AxisLabel = "", Label = "#PERCENT{P0}", LegendText = genreCounts[j].Genre };
                    series.Points.Add(dpTemp);
                }
            });

             
            // Add to chart
            chart1.Series.Add(series);

            this.Controls.Add(chart1);

        }
        private void BarChart()
        { 
            var chart = new Chart
            {
                Size = new Size(500, 340),
                Location = new Point(-45, 150),
                Palette = ChartColorPalette.Excel, 
                BackColor = main.HomeScreen.Panel.BackColor,
                BackSecondaryColor = main.HomeScreen.Panel.BackColor,
                BorderColor = main.HomeScreen.Panel.BackColor
            };
            // Chart area
            var chartArea = new ChartArea("MainArea")
            {
                BackColor = Color.White
            };
            chartArea.AxisX.Title = "Categories";
            chartArea.AxisY.Title = "Values";
            chartArea.AxisX.Interval = 1;
            chartArea.Position = new ElementPosition(5, 5, 90, 90);
            chartArea.InnerPlotPosition = new ElementPosition(10, 10, 80, 80);
            chart.ChartAreas.Add(chartArea);
             
            chartArea.AxisX.MajorGrid.Enabled = false;
            main.SQLAccess(x =>
            {
                //LINQ USAGE:
                var assetCounts = x.Games
                    .GroupJoin(
                    x.Assets,
                game => game.GameId,
               asset => asset.GameId,
                    (game, assets) => new
                    {
                        GameTitle = game.Title,
                        AssetCount = assets.Count()
                    }).ToList();

                for (int j = 0; j < assetCounts.Count(); j++)
                { 
                    var series = new Series(assetCounts[j].GameTitle);
                    //double safeValue = assetCounts[j].AssetCount == 0 ? 0.05 : assetCounts[j].AssetCount;
                    series.Points.AddXY("Games", assetCounts[j].AssetCount);
                    chart.Series.Add(series); //ERROR HERE GAME 11 EKLEYINCE SIKINTI
                    series.IsValueShownAsLabel = true;
                }



            });


            foreach (Series series in chart.Series)
            {
                series.ChartType = SeriesChartType.Column;
                series.IsValueShownAsLabel = true;
                series["PointWidth"] = "2";
            }

            chart.MouseMove += Chart_MouseMove;
            this.Controls.Add(chart);
        }
        private ToolTip chartToolTip = new ToolTip();
        private void Chart_MouseMove(object sender, MouseEventArgs e)
        {
            Chart chart = sender as Chart;
            HitTestResult result = chart.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                var series = result.Series;
                int pointIndex = result.PointIndex;
                var point = series.Points[pointIndex];

                string text = $"{series.Name}: {point.YValues[0]} Assets";

                // Show tooltip near cursor
                chartToolTip.Show(text, chart, e.X + 15, e.Y + 15);
            }
            else
            {
                // Hide tooltip if not on a data point
                chartToolTip.Hide(chart);
            }
        }
    }
}
