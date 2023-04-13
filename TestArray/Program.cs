using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArray
{
    public class Program
    {
        private static int NumberCount = 20;
        private static readonly Random Random = new Random();
        static void Main(string[] args)
        {
            var array = Enumerable.Range(0, NumberCount).Select(_=>Random.Next(10)).ToArray();
            array = array.OrderBy(x => x).ToArray();
        }
    }
}
