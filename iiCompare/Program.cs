using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iiCompare
{
	class Program
	{
		static void Main(string[] args)
		{
			//Item a = new Item();
			//Item b = new Item();
			//var x = Item.Equals(a,b);
			//Console.WriteLine(x);

			//Item k = a;
			//x = Item.Equals(a, k);
			//Console.WriteLine(x);

			Item b = new Item()
			{
				Name = "cc"
			};
			Item c = new Item()
			{
				Name = "cc"
			};
			int x = b.CompareTo(c);
			Console.WriteLine(x);

			int y = b.Compare(b, c);
			Console.WriteLine(x);


			Console.ReadKey();
		}
	}
}
