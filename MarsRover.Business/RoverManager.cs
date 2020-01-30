using MarsRover.Business.Contracts;
using MarsRover.Models;
using MarsRover.Models.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Extensions;
namespace MarsRover.Business
{
    public class RoverManager : IRoverService
    {
        public Rover Initialize(RoverPositionModel roverPositionModel)
        {
            return roverPositionModel.Generate();
        }
    }
}
