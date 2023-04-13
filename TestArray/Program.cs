using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestArray.Entities;
using TestArray.Extensions;

namespace TestArray
{
    public class Program
    {
        private const int NumberCount = 20;
        private const int NumberStart = 0;
        private const int NumberEnd = 99;
        private static int ValueLengthStart = 1;
        private static int ValueLengthEnd = 5;
        private static readonly Random Random = new Random();
        static void Main(string[] args)
        {
            var array = Enumerable.Range(0, NumberCount).Select(_=>new Item { Number = Random.Next(10),Value=new string('x',Random.Next(ValueLengthStart, ValueLengthEnd+1)) }).ToArray();
            array = array.OrderBy(x => x.Number).ToArray();
            Console.WriteLine(string.Join(", ", array.Select(i=>$"{i.Number} - {i.Value}")));
			array.Select((value, index) => $"{index,2}: {value,2}").ForEach(Console.WriteLine);
            Console.ReadKey();        }
    }
}
