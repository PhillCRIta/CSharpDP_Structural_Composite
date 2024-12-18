using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Composite
{
	internal class Keyboard : IItem
	{
		private float _price = 40.00f;
		public float GetPrice()
		{
			return _price;
		}
	}
}
