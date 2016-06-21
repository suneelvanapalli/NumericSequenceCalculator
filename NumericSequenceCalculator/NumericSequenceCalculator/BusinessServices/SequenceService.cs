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
            throw new NotImplementedException();
        }

        public List<int> GetAllFibonacciNumbers(int input)
        {
            throw new NotImplementedException();
        }

        public List<int> GetAllNumbers(int input)
        {
            throw new NotImplementedException();
        }

        public List<int> GetAllOddNumbers(int input)
        {
            throw new NotImplementedException();
        }

        public List<int> GetNumbersInCustomFormat(int input)
        {
            throw new NotImplementedException();
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