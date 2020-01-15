/*
 * Created by SharpDevelop.
 * User: valmac
 * Date: 16.01.2020
 * Time: 1:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FormsChart
{
	/// <summary>
	/// Description of RoCalculator.
	/// </summary>
	public class RoCalculator : IRoCalculator
	{
		private readonly float _a;
		private readonly float _f;
		private readonly float _b;
		
		
		public RoCalculator(float a, float f, float b)
		{
			if(f.Equals(0))
				throw new ArgumentException("F can't be zero");
			
			_a = a;
			_f = f;
			_b = b;
		}
		
		public bool TryCalcRo(float arg, out float value)
		{
			if(arg.Equals(0))
			{
				value = float.NaN;
				return false;
			}
			
			value = _a / (_f * arg) + _b;
			
			return true;
		}
	}
}

