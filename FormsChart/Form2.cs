/*
 * Created by SharpDevelop.
 * User: valmac
 * Date: 15.01.2020
 * Time: 1:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FormsChart
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		private Series _series;
		
		public Form2()
		{
			InitializeComponent();
			_series = new Series();
		}
		
		protected override void OnLoad(EventArgs e)
		{
			chart.Series.Clear();
			chart.Titles.Add("График функции:\nRo=A/Fi + B" );
		}
		
		internal void SetUpChart(string seriesName)
		{
			chart.Series.Clear();
			
			_series = chart.Series.Add(seriesName);
			_series.Color = System.Drawing.Color.Red;
			_series.ChartType = SeriesChartType.Polar;
		}
		
		internal void AddPoint(float x, float y)
		{
			_series.Points.AddXY(x, y);
		}
	}
}
