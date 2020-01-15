/*
 * Created by SharpDevelop.
 * User: valmac
 * Date: 15.01.2020
 * Time: 2:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FormsChart
{
	/// <summary>
	/// Интерфейс вычислителя функции
	/// </summary>
	public interface IRoCalculator
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="arg"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		bool TryCalcRo(float arg, out float value);
	}
}
