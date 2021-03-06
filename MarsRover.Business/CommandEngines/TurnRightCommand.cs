﻿using MarsRover.Business.Contracts;
using MarsRover.Models;
using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business.CommandEngines
{
    public class TurnRightCommand : ICommand
    {
        public void Execute(Rover rover)
        {
            switch (rover.Direction)
            {
                case Direction.North:
                    rover.Direction = Direction.East;
                    break;
                case Direction.East:
                    rover.Direction = Direction.South;
                    break;
                case Direction.South:
                    rover.Direction = Direction.West;
                    break;
                case Direction.West:
                    rover.Direction = Direction.North;
                    break;
            }
        }
    }

}
