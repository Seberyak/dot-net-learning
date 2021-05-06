using System;
using System.Collections.Generic;
using LearningDotNet_1.Models;

namespace LearningDotNet_1.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public List<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan"},
                new Command {Id = 1, HowTo = "Cut bred", Line = "Get a knife", Platform = "Kettle & Pan"},
                new Command {Id = 2, HowTo = "Make tea", Line = "Place teabag in cup", Platform = "Kettle & Pan"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id = id, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan"};
        }
    }
}