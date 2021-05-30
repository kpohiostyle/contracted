using System.Collections.Generic;
using contracted.Models;
using contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace contracted.Controllers
{
    [ApiController]
    [Route("api/[controller")]
    public class ContratorsController : ControllerBase
    {
        private readonly ContratorsService _contractorsService;

        public ContratorsController(ContratorsService contractorsService)
        {
            _contractorsService = contractorsService;
        }

        [HttpGet]
        public ActionResult<List<Contractor>> GetAll()
        {
            List<Contractor> contractors = _contractorsService.GetAll();
            return Ok(contractors);
        }
        [HttpPost]
        public ActionResult<Contractor> Create([FromBody] Contractor newContractor)
        {
            Contractor contractor = _contractorsService.Create(newContractor);
            return Ok(newContractor);
        }

    }
}