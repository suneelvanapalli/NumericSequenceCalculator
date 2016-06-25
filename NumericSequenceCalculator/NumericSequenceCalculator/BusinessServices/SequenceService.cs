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

      
        public List<int> GetAllFibonacciNumbers(int len)
        {
            var seq = new List<int>();
             Fibonacci_Rec_Temp(0, 1,len,seq);
            return seq;

        }

        private static List<int> Fibonacci_Rec_Temp(int a, int b,int len , List<int> sequence)
        {
            if (a <= len)
            {
                sequence.Add(a);
                Fibonacci_Rec_Temp(b, a + b, len,sequence);
            }
            return sequence;
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

        private bool IsMultiple(int x, int n)
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