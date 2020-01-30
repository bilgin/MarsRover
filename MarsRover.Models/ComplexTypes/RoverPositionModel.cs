using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Models.ComplexTypes
{
    public class RoverPositionModel
    {
        public RoverPositionModel(int xLocation, int yLocation, Direction direction)
        {
            Direction = direction;
            XLocation = xLocation;
            YLocation = yLocation;
        }
        public Direction Direction { get; set; }
        public int XLocation { get; set; }
        public int YLocation { get; set; }
    }
}
