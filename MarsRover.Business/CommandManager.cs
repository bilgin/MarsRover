using MarsRover.Business.CommandEngines;
using MarsRover.Business.Contracts;
using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business
{
    public class CommandManager : ICommandService
    {
        public ICommand Generate(Movement movement)
        {
            ICommand command = null;

            switch (movement)
            {
                case Movement.Right:
                    command = new TurnRightCommand();
                    break;
                case Movement.Left:
                    command = new TurnLeftCommand();
                    break;
                case Movement.Move:
                    command = new ForwardMoveCommand();
                    break;
            }

            return command;
        }
    }

}
