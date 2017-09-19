using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace AriQualityMonitoring
{
    public partial class ChartForm : Form
    {
        private Series AirQualitySeries;
        public ChartForm()
        {
            InitializeComponent();

            //AirQualityChart AirQualityChartObj = new AirQualityChart();

            AirQualitySeries = AirQualityChart.Series[0];
            AirQualitySeries.ChartType = SeriesChartType.Line;
            AirQualitySeries.BorderWidth = 2;
            AirQualitySeries.Color = System.Drawing.Color.Red;
            AirQualitySeries.LegendText = "湿度曲线";


            ChartArea AirQualityChartArea = AirQualityChart.ChartAreas[0];
            AirQualityChartArea.AxisX.Minimum = 0;
            AirQualityChartArea.AxisX.Maximum = 100;
            AirQualityChartArea.AxisY.Minimum = 0d;
            AirQualityChartArea.AxisY.Maximum = 100d;



        }

        public void AirQualityPoint(int x,float y)
        {
            AirQualitySeries.Points.AddXY(x, y);
        }





    }
}
