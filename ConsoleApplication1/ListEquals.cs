using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    class ListEquals
    {
        public static bool Equals(object obj1, object obj2)
        {
            var targetArray = getObjectByte(obj1);
            var expectedArray = getObjectByte(obj2);
            var equals = expectedArray.SequenceEqual(targetArray);
            return equals;
        }

        private static byte[] getObjectByte(object model)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                XmlSerializer xs = new XmlSerializer(model.GetType());
                xs.Serialize(memory, model);
                var array = memory.ToArray();
                return array;
            }
        }
    }
}
