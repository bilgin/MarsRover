using MarsRover.Models;
using MarsRover.Models.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Extensions
{
    public static class RoverExtensions
    {
        public static Rover Generate(this RoverPositionModel roverPositionModel)
        {
            return new Rover
            {
                Direction = roverPositionModel.Direction,
                XLocation = roverPositionModel.XLocation,
                YLocation = roverPositionModel.YLocation
            };
        }

    }

}
