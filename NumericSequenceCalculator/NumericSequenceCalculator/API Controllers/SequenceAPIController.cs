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
        [Route("generate-sequence/{input}/{sequenceType}")]
        public List<int> GetAllNumbers(int input, string sequenceType)
        {
            return _sequenceService.GetAllNumbers(input);
        }

        [HttpGet]
        [Route("getsequencetypes")]
        public List<SequenceType> GetSequenceTypes()
        {
            return _sequenceService.GetSequenceTypes();
        }



    }
}
