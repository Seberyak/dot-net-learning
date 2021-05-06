using System.Collections.Generic;
using LearningDotNet_1.Data;
using LearningDotNet_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningDotNet_1.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();
            return Ok(commandItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            return Ok(_repository.GetCommandById(id));
        }
    }
}