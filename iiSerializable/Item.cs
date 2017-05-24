using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iiSerializable
{
	[Serializable]
	public class Item: ISerializable
	{
		public Item()
		{
			// Empty constructor required to compile.
		}
		
		// The special constructor is used to deserialize values.
		public Item(SerializationInfo info, StreamingContext context)
		{
			// Reset the property value using the GetValue method.
			School = (string)info.GetValue("school", typeof(string));
			Name = (string)info.GetValue("name", typeof(string));
			Age = (string)info.GetValue("age", typeof(string));
		}

		// The value to serialize.
		public string Name { get; set; }
		public string Age { get; set; }
		public string School { get; set; }

		// Implement this method to serialize data. The method is called 
		// on serialization.
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			// Use the AddValue method to specify serialized values.
			info.AddValue("school", School, typeof(string));
			info.AddValue("name", Name, typeof(string));
			info.AddValue("age", Age, typeof(string));

		}

	}
}
