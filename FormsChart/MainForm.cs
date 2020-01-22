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
		
		/// <summary>
		/// метод вычисления функции Ro
		/// </summary>
		private IRoCalculator _calculator;
		
		public MainForm()
		{
			InitializeComponent();			
		}
		
		/// <summary>
		/// Метод обработки события загрузки главной формы
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
		
		/// <summary>
		/// Метод обработки события клика по кнопке "Построить график"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btDrawChartClick(object sender, EventArgs e)
		{
			// формируем наименование серии
			string seriesName = string.Concat ("Ro=", nudA.Value.ToString("F1"),
			                                   "/Fi ", 
			                                   nudB.Value >0 ? "+":string.Empty,
			                                   nudB.Value.ToString("F1"));
			
			// подготавливаем серию на второй форме (с графиком)
			_chartForm.SetUpChart(seriesName);
			
			// создаем калькулятор для расчета функции
			_calculator = new RoCalculator((float) nudA.Value, (float) nudB.Value);
			
			// переменная для значений ro			
			float ro = float.NaN;
			
			// шаг расчета
			float step = 0.1f;
			
			// цикл расчета
			for(float fi = 0f; fi < 360f; fi += step)
			{
				// расчет был успешным ?
				if(_calculator.TryCalcRo(fi, out ro))
				{
					// добавим значение на вторую форму (с графиком)
					_chartForm.AddPoint(fi, ro);
				}
			}
		}
	}
}
