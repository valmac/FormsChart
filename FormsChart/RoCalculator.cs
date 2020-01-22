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
	/// Класс RoCalculator  - это простейшая имплементация интерфейса IRoCalculator 
	/// </summary>
	public class RoCalculator : IRoCalculator
	{
		public float A {get; private set;}
		
		public float B {get; private set;}
		
		public RoCalculator(float a,  float b)
		{
			A = a;
			B = b;
		}
		
		public bool TryCalcRo(float fi, out float ro)
		{
			if(fi.Equals(0))
			{
				ro = float.NaN;
				return false;
			}
			
			ro = A / fi  + B;
			return true;
		}
	}
}

