using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    public class NumberSequence
    {
        public List<int> Numbers { get; private set; }

        public NumberSequence()
        {
            Numbers = new List<int>();
        }

        public void AddNumbers(string input)
        {
            var numbers = input.Split(' ')
                               .Where(n => int.TryParse(n, out _))
                               .Select(int.Parse)
                               .ToList();
            Numbers.AddRange(numbers);
        }

        public int Sum() => Numbers.Sum();

        public int SumEven() => Numbers.Where(n => n % 2 == 0).Sum();

        public int SumOdd() => Numbers.Where(n => n % 2 != 0).Sum();
    }
}
