using Core.Factories;
using Core.Models;
using Core.Problems;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProblemsController : ControllerBase
    {
        [HttpPost]
        [Route("{problem}")]
        public IActionResult SolveProblem(string problem, string? args)
        {
            IProblem? worker = null;

            Parameters parameters = ArgParser.GetParameters(ArgGenerator.GetArguments(problem));

            if (parameters.Problem == null) return BadRequest();

            if (args != null) parameters.Input = args;

            worker = WorkerFactory.GetWorker(parameters.Problem);

            if (worker == null) return BadRequest();

            if (parameters.Input == null) return BadRequest();

            return Ok(worker.Solve(parameters.Input));
        }
    }
}
