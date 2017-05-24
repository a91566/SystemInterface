using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iiCompare
{
	public class Item : System.Collections.IComparer, System.IComparable
	{
		public string Name { get; set; }

		public int Compare(Object x, Object y)
		{
			return ((new System.Collections.CaseInsensitiveComparer()).Compare(y, x));
		}


		public int CompareTo(object obj)
		{
			if (obj == null) return 1;
			Item item = obj as Item;
			if (item != null)
				return this.Name.CompareTo(item.Name);
			else
				throw new ArgumentException("Object is not a Item");
		}
	}


}
