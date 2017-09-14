using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structured
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLists list = new LinkedLists();
            object objects = "25";
            list.AddFirst(objects);

            objects = "1233";
            list.AddFirst(objects);

            objects = "22333";
            list.AddFirst(objects);

            objects = "123555";
            list.AddFirst(objects);

            Console.WriteLine(list.Contains("123555").ToString());
            List<string> listInfo = list.GetEnumerator().ToList<string>();
            foreach (string str in listInfo)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
