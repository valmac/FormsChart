/*
 * Created by SharpDevelop.
 * User: valmac
 * Date: 16.01.2020
 * Time: 1:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace FormsChart
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var form = new MainForm();
			Application.Run(form);
			Console.WriteLine("Application exit.");
		}
		
	}
}
