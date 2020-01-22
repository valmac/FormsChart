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
	/// Интерфейс вычислителя функции Ro=A/Fi+B, 
	/// где A и B - численные параметры,
	/// а Fi - аргумент который изменяется от 0 до 360
	/// </summary>
	public interface IRoCalculator
	{
		/// <summary>
		/// Значение числового параметра A
		/// </summary>
		float A {get;}
		/// <summary>
		/// Значение числового параметра B  
		/// </summary>
		float B {get;}
		/// <summary>
		/// Возвращает результат расчета функции Ro от аргумента Fi
		/// </summary>
		/// <param name="fi">значение аргумента аргумента Fi</param>
		/// <param name="ro">результат вычисления функции Ro в случае успеха расчета.
		/// В случае неудачи расчета возвращает float.NaN</param>
		/// <returns>в случае успеха возвращает true, иначе возвращает false</returns>
		bool TryCalcRo(float fi, out float ro);
	}
}
