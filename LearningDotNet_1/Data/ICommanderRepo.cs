using System.Collections.Generic;
using LearningDotNet_1.Models;

namespace LearningDotNet_1.Data
{
    public interface ICommanderRepo
    {
        List<Command> GetAppCommands();

        Command GetCommandById(int id);
    }
}