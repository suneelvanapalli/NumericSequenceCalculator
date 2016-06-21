using NumericSequenceCalculator.BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumericSequenceCalculator.Controllers
{
    public class SequenceController : Controller
    {

        private readonly ISequenceService _sequenceService;

        public SequenceController(ISequenceService sequenceService)

        {
            _sequenceService = sequenceService;
        }


        // GET: Sequence
        public ActionResult Index()
        {
            return View();
        }
    }
}