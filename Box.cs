using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Composite
{
	internal class Box : IItem
	{
		private List<IItem> _items = new List<IItem>();

		public void Add(IItem item)
		{
			_items.Add(item);
		}

		public float GetPrice()
		{
			float totalPrice = 0;
			foreach (IItem item in _items)
			{
				//every objects are trated as the same of IItem object, based on their interface
				totalPrice += item.GetPrice();
			}
			return totalPrice;
		}
	}
}
