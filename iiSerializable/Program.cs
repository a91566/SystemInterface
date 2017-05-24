using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace iiSerializable
{
	class Program
	{
		static void Main(string[] args)
		{
			// This is the name of the file holding the data. You can use any file extension you like.
			string fileName = "dataStuff.myData";

			// Use a BinaryFormatter or SoapFormatter.
			IFormatter formatter = new BinaryFormatter();
			//IFormatter formatter = new SoapFormatter();

			Program.SerializeItem(fileName, formatter); // Serialize an instance of the class.
			Program.DeserializeItem(fileName, formatter); // Deserialize the instance.

			Console.WriteLine("Done");
			Console.ReadLine();
		}

		public static void SerializeItem(string fileName, IFormatter formatter)
		{
			// Create an instance of the type and serialize it.
			ItemInterface t = new ItemInterface();
			t.Name = "Hello World";
			t.School = "qinghua";
			t.Age = "18";

			FileStream s = new FileStream(fileName, FileMode.Create);
			formatter.Serialize(s, t);
			s.Close();
		}


		public static void DeserializeItem(string fileName, IFormatter formatter)
		{
			FileStream s = new FileStream(fileName, FileMode.Open);
			ItemInterface t = (ItemInterface)formatter.Deserialize(s);
			Console.WriteLine(t.Name);
			Console.WriteLine(t.School);
			Console.WriteLine(t.Age);
		}
	}
}
