/*
 * Created by SharpDevelop.
 * User: valmac
 * Date: 15.01.2020
 * Time: 1:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace FormsChart
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Форма для построения графика
		/// </summary>
		private Form2 _chartForm;
		
		private IRoCalculator _calculator;
		
		public MainForm()
		{
			InitializeComponent();			
		}
		
		/// <summary>
		/// Событие загрузки главной формы
		/// </summary>
		/// <param name="e"></param>
		protected override void OnLoad(EventArgs e)
		{
			_chartForm = new Form2();
			// при закрытии формы графика обработать это событие
			_chartForm.FormClosed += (obj, args) => 
			{
				// закрыть главную форму
				Close();
				// выйти из приложения
				Environment.Exit(0);
			};
			
			// отобразить форму для построения графика
			_chartForm.Show();
			_chartForm.StartPosition = FormStartPosition.Manual;
			_chartForm.Location =  new System.Drawing.Point(Location.X + this.Size.Width, Location.Y);
		}
		
		private void btDrawChartClick(object sender, EventArgs e)
		{
			if(!IsInputOk())
			{
				MessageBox.Show("Некорректный параметр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			string seriesName = string.Concat ("Ro=", nudA.Value.ToString("F1"),
			                                   "/(", nudF.Value.ToString("F1"),
			                                   "*i) + ", nudB.Value.ToString("F1"));
			_chartForm.ClearChart(seriesName);
			
			_calculator = new RoCalculator((float) nudA.Value, (float) nudF.Value, (float) nudB.Value);
			
			float min = (float) nudMin.Value;
			float max = (float) nudMax.Value;
			float step = (float) nudStep.Value;
			
			float value = float.NaN;
			
			for(float arg = min; arg < max; arg += step)
			{
				if(_calculator.TryCalcRo(arg, out value))
				{
					_chartForm.AddPoint(arg, value);
				}
			}
		}
		
		private bool IsInputOk()
		{
			return nudF.Value != 0m;
		}
	}
}
