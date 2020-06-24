using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NW.Income.API.Core;
using NW.Income.API.Model;

namespace NW.Income.API.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class IncomeQuestionnaireController : ControllerBase
    {
        private readonly ILogger<IncomeQuestionnaireController> _logger;
        private readonly IIncomeBL _incomeBL;

        public IncomeQuestionnaireController(ILogger<IncomeQuestionnaireController> logger, IIncomeBL incomeBL)
        {
            _logger = logger;
            _incomeBL = incomeBL;

        }

        [HttpGet]
        public IEnumerable<IncomeQuestionnaire> Get()
        {
            return _incomeBL.GetAll().ToArray();
        }

        [HttpPost]
        public void Post([FromBody] IncomeQuestionnaire incomeQuestionnaire)
        {
            _incomeBL.Add(incomeQuestionnaire);
        }
    }
}
