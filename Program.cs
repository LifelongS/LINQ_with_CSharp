using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_with_CSharp
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var collection = new List<item>();

            var collection = new List<Product>(); 
            for (var i = 0; i < 10; i++)
            {
                //var product = new item()
                var product = new Product()
                {
                    //на примере энергетической ценности продуктов
                    Name = "Продукт" + i,
                    Energy = rnd.Next(10, 11)
                };
                //collection.Add(i);
                collection.Add(product);
            }

            var result = from item in collection 
                         where item.Energy < 200 
                         //orderby item.Energy
                         select item;

            var result2 = collection.Where(item => item.Energy < 200);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }


            var selectCollection = collection.Select(product => product.Energy);
            foreach (var item in selectCollection)
            {
                Console.WriteLine(item);
            }

            var orderbyCollection = collection.OrderBy(product => product.Energy)
                                              .ThenByDescending(product => product.Name);
            foreach (var item in orderbyCollection)
            {
                Console.WriteLine(item);
            }

            var groupbyCollection = collection.GroupBy(product => product.Energy);
            foreach (var group in groupbyCollection)
            {
                Console.WriteLine($"Ключ: {group.Key}"); 
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
                Console.WriteLine();
            }

            collection.Reverse();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

                Console.WriteLine(collection.All(item => item.Energy == 10)); 
                Console.WriteLine(collection.Any(item => item.Energy == 10));
            Console.WriteLine(collection.Contains(collection[5]));

            var prod = new Product(); 
            Console.WriteLine(collection.Contains(prod)); 
            var array = new int[] { 1, 2, 3, 4 };
            var array2 = new int[] { 3, 4, 5, 6 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var union = array.Union(array2);
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var intersect = array.Intersect(array2);
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var except = array2.Except(array);
            foreach (var item in except)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var sum = array.Sum(); 
            var min = collection.Min(p => p.Energy);
            var max = collection.Max(p => p.Energy);
            var aggregate = array.Aggregate((x, y) => x*y);

            var sum2 = array.Skip(1).Take(2).Sum();

            //var first = array.First(); 
            var first = collection.First(product => product.Energy == 10);
            var last = array.Last();
            //var last = array.LastOfDefault();

            //var single = collection.Single(product => product.Energy == 10);

            var elementAt = collection.ElementAt(5);

            Console.ReadLine();
        }
    }
}