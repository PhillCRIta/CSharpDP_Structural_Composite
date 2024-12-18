using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Structural_Composite
{
	internal class Microphone:IItem
	{
		private float _price = 20.99f;

		public float GetPrice()
		{
			return _price;
		}
	}
}
