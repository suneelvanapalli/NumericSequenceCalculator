using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCalculator.BusinessServices
{
    public interface ISequenceService
    {
        List<int> GetAllNumbers(int input);
        List<int> GetAllOddNumbers(int input);
        List<int> GetAllEvenNumbers(int input);
        List<string> GetNumbersInCustomFormat(int input);
        List<int> GetAllFibonacciNumbers(int input);

        List<SequenceType> GetSequenceTypes();
    }
}
