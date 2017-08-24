using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list1 = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                list1.Add(new Person()
                {
                    Age = i,
                    Address = "地址" + i.ToString(),
                    Name = new Name("Huang", "Kerry" + i.ToString())
                });
            }

            List<Person> list2 = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                list2.Add(new Person()
                {
                    Age = i,
                    Address = "地址" + i.ToString(),
                    Name = new Name("Huang", "Kerry" + i.ToString())
                });
            }

            if (ListEquals.Equals(list1, list2.OrderByDescending(x => x.Age).ToList()))
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False");
            }
            Console.ReadKey();
        }
    }
}
