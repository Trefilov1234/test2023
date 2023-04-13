using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestArray.Extensions;

namespace TestArray
{
    public class Program
    {
        private const int NumberCount = 20;
        private const int NumberStart = 0;
        private const int NumberEnd = 99;
        private static readonly Random Random = new Random();
        static void Main(string[] args)
        {
            var array = Enumerable.Range(0, NumberCount).Select(_=>Random.Next(NumberStart,NumberEnd+1)).ToArray();
            array = array.OrderBy(x => x).ToArray();
            array.Select((value, index) => $"{index,2}: {value,2}").ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
