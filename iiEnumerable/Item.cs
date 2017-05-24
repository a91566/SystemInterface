using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iiEnumerable
{
	public class Item: System.Collections.IEnumerable
	{
		public string Name { get; set; }

		// Implementation for the GetEnumerator method.
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)GetEnumerator();
		}

		public Item GetEnumerator()
		{
			//return new Item(Name);
			return null;
		}
	}
}
