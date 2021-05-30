using System.Collections.Generic;
using contracted.Models;
using contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace contracted.Controllers
{

    [ApiController]
    [Route("api/[controller")]
    public class JobsController : ControllerBase
    {
        private readonly JobsService _jobsService;

        public JobsController(JobsService jobsService)
        {
            _jobsService = jobsService;
        }

        [HttpGet]
        public ActionResult<List<Job>> GetAll()
        {
            try
            {
                List<Job> jobs = _jobsService.GetAll();
                return Ok(jobs);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Job> Create([FromBody] Job newJob)
        {
            Job jobs = _jobsService.Create(newJob);
            return Ok(newJob);
        }
    }
}