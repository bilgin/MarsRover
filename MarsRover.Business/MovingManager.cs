using MarsRover.Business.Contracts;
using MarsRover.Extensions;
using MarsRover.Models;
using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business
{
    public class MovingManager : IMovingService
    {
        private ICommandService _commandService;
        public MovingManager(ICommandService commandService)
        {
            _commandService = commandService;
        }

        public Rover ExecuteCommand(Rover rover, string movingCommand)
        {
            List<Movement> commands = new List<Movement>().ConvertToMovements(movingCommand);
            commands.ForEach(movement =>
            {
                _commandService.Generate(movement).Execute(rover);
            });

            return rover;
        }
    }

}
