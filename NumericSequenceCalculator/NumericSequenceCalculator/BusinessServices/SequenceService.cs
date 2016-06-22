using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumericSequenceCalculator.BusinessServices
{
    public class SequenceService : ISequenceService
    {
        public List<int> GetAllEvenNumbers(int input)
        {
            return Enumerable.Range(1, input)
                          .Where(x => x % 2 == 0)
                          .ToList();
        }

        public List<int> GetAllFibonacciNumbers(int input)
        {
            int Range = 10;
            int ord1 = 0, ord2 = 0, ord3 = 0;
            var FibSeries = Enumerable.Range(1, Range).Select(a =>
            {
                ord1 = a == 1 ? 0 : ord2;
                ord2 = a == 1 ? 1 : ord3;
                ord3 = a == 1 ? 0 : ord1 + ord2;
                return ord3;
            }).ToList();

            return FibSeries;
        }

        public List<int> GetAllNumbers(int input)
        {
            return Enumerable.Range(1, input).ToList();
        }

        public List<int> GetAllOddNumbers(int input)
        {
            return Enumerable.Range(1, input)
                          .Where(x => x % 2 != 0)
                          .ToList();
        }

        public List<string> GetNumbersInCustomFormat(int input)
        {
            return Enumerable.Range(1, input)
                          .Select(x => GetCustomFormat(x))
                          .ToList();
        }

        public bool IsMultiple(int x, int n)
        {
            return (x % n) == 0;
        }

        private string GetCustomFormat(int input)
        {
            if (IsMultiple(input, 3) && IsMultiple(input, 5))
            {
                return "Z";
            }

            if (IsMultiple(input, 3))
            {
                return "C";
            }

            if (IsMultiple(input, 5))
            {
                return "E";
            }

            return input.ToString();
        }

        public List<SequenceType> GetSequenceTypes()
        {
            return new List<SequenceType>()
            {
                new SequenceType { ID="ALL" , Name="AllNumbers" },
                new SequenceType { ID="EVEN" , Name="Even" },
                new SequenceType { ID="ODD" , Name="Odd" },
                new SequenceType { ID="CUSTOM" , Name="Custom" },
                new SequenceType { ID="FIBONACCI" , Name="Fibonacci" },
            };
        }
    }
}