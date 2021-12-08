using System;
using ArrayLibrary;

namespace ConsoleForTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                arrayList.AddInEnd(random.Next(0, 100));
            }

            arrayList.Print();
            Console.WriteLine("");
            int minID = arrayList.ArrayListMinID();
            Console.WriteLine("");
            Console.WriteLine(minID);
            int min = arrayList.ArrayListMin();
            Console.WriteLine("");
            Console.WriteLine(min);
            Console.WriteLine("");
            arrayList.AddInStart(3);
            arrayList.Print();
            Console.WriteLine("");
            arrayList.AddByIndex(10,3);
            arrayList.Print();
            Console.WriteLine("");
            arrayList.RemoveByIndexN(2,5);
            arrayList.Print();
            Console.WriteLine("");
            arrayList.ArrayReverse();
            arrayList.Print();
            Console.WriteLine("");
            arrayList.ChangeByIndex(4, 2);
            arrayList.Print();
            //ArrayList arrayList2 = new ArrayList();
            //for (int i = 0; i < 5; i++)
            //{
            //    arrayList2.AddInEnd(random.Next(0, 100));
            //}
            //Console.WriteLine("");
            //arrayList.Print();
            //Console.WriteLine("");
            //arrayList2.Print();
            //arrayList.AddArrayByIndex(arrayList2, 3);
            //Console.WriteLine("");
            //arrayList.Print();

            //arrayList.AddArrayByIndex(arrayList2, 3);
            //Console.WriteLine("");
            //arrayList.Print();
            //int minID = arrayList.ArrayListMinID();
            //int min = arrayList.ArrayListMin();
            //Console.WriteLine(minID + " " + min);
            //arrayList.Print();
        }
    }
}
