using NumericSequenceCalculator.BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NumericSequenceCalculator.API_Controllers
{
    [RoutePrefix("api/sequence")]
    public class SequenceAPIController : ApiController
    {
        private readonly ISequenceService _sequenceService;

        public SequenceAPIController(ISequenceService sequenceService)
        {
            _sequenceService = sequenceService;
        }

        [HttpPost]
        [Route("generate-sequence/all/{input}")]
        public List<int> GetAllNumbers(int input)
        {
            return _sequenceService.GetAllNumbers(input);
        }

        [HttpPost]
        [Route("generate-sequence/even/{input}")]
        public List<int> GetAllEvenNumbers(int input)
        {
            return _sequenceService.GetAllEvenNumbers(input);
        }


        [HttpPost]
        [Route("generate-sequence/odd/{input}")]
        public List<int> GetAllOddNumbers(int input)
        {
            return _sequenceService.GetAllOddNumbers(input);
        }

        [HttpPost]
        [Route("generate-sequence/custom/{input}")]
        public List<string> GetNumbersInCustomFormat(int input)
        {
            return _sequenceService.GetNumbersInCustomFormat(input);
        }

        [HttpPost]
        [Route("generate-sequence/fibonacci/{input}")]
        public List<int> GetAllFibonacciNumbers(int input)
        {
            return _sequenceService.GetAllFibonacciNumbers(input);
        }
        
        [HttpGet]
        [Route("getsequencetypes")]
        public List<SequenceType> GetSequenceTypes()
        {
            return _sequenceService.GetSequenceTypes();
        }



    }
}
