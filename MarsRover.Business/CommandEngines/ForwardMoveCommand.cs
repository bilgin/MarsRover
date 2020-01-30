using MarsRover.Business.Contracts;
using MarsRover.Models;
using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business.CommandEngines
{
    public class ForwardMoveCommand : ICommand
    {
        public void Execute(Rover rover)
        {
            switch (rover.Direction)
            {
                case Direction.North:
                    rover.YLocation += 1;
                    break;
                case Direction.East:
                    rover.XLocation += 1;
                    break;
                case Direction.South:
                    rover.YLocation -= 1;
                    break;
                case Direction.West:
                    rover.XLocation -= 1;
                    break;
            }
        }
    }

}
