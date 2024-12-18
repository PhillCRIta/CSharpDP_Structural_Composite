using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Composite
{
	internal class Mouse : IItem
	{
		private float _price = 18.00f;
		public float GetPrice()
		{
			return _price;
		}
	}
}
