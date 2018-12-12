using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverview
{
    class Program
    {
        static string[] namesArray = { "Tom", "Dick", "Harry", "Mary", "Cris", "Tom", "Caroline" };

        static string[] namesArray1 = { "Dick", "Mary", "Caroline", "Carlos" };

        static void Main(string[] args)
        {
            var query = (from n in namesArray
                         select n);

            // 1. Filtering Methods 

            IEnumerable<string> name = namesArray.Where(x => x.Contains("r"));
            Console.WriteLine("____Where____");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> name1 = namesArray.Take(2);
            Console.WriteLine("____Take____");
            foreach (var item in name1)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> name3 = namesArray.Skip(3);
            Console.WriteLine("____Skip____");
            foreach (var item in name3)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> name4 = namesArray.SkipWhile(x => x.StartsWith("C"));
            Console.WriteLine("____Skip While____");
            foreach (var item in name4)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> name5 = namesArray.TakeWhile(x => x.StartsWith("C"));
            Console.WriteLine("____Take While____");
            foreach (var item in name5)
            {
                Console.WriteLine(item);
            }

            // 2. Projection Methods 

            Console.WriteLine("____Select____");
            var name6 = namesArray.Select(x => x.Length);
            foreach (var item in name6)
            {
                Console.WriteLine(item);
            }
            
            // 3. Join Methods

            // 4. Ordering Methods

            IEnumerable<string> name9 = namesArray.OrderBy(x => x);
            Console.WriteLine("____OrderBy____");
            foreach (var item in name9)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> name10 = namesArray.OrderByDescending(x => x);
            Console.WriteLine("____OrderByDescending____");
            foreach (var item in name10)
            {
                Console.WriteLine(item);
            }

            // 5. Set Methods

            IEnumerable<string> name11 = namesArray.Except(namesArray1);
            Console.WriteLine("____Except____");
            foreach (var item in name11)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> name12 = namesArray.Intersect(namesArray1);
            Console.WriteLine("____Intersect____");
            foreach (var item in name12)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> name13 = namesArray.Union(namesArray1);
            Console.WriteLine("____Union____");
            foreach (var item in name13)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> name14 = namesArray.Distinct();
            Console.WriteLine("____Distinct____");
            foreach (var item in name14)
            {
                Console.WriteLine(item);
            }

            // 6. 

            string name15 = namesArray.Single(x => x.Length > 7);
            Console.WriteLine("____Single____");
            Console.WriteLine(name15);

            string name16 = namesArray.Where(x => x.Length > 8).SingleOrDefault();
            Console.WriteLine("____SingleOrDefault____");
            Console.WriteLine(name16);

            string name17 = namesArray.First(x => x.StartsWith("H"));
            Console.WriteLine("____First____");
            Console.WriteLine(name17);

            string name18 = namesArray.FirstOrDefault(x => x.StartsWith("K")); 
            Console.WriteLine("____FirstOrDefault____");
            Console.WriteLine(name18);

            string name19 = namesArray.Last(x => x.StartsWith("M"));
            Console.WriteLine("____Last____");
            Console.WriteLine(name19);

            string name20 = namesArray.LastOrDefault(x => x.StartsWith("N"));
            Console.WriteLine("____LastOrDefault____");
            Console.WriteLine(name20);


            Console.ReadKey();
        }
    }
}
