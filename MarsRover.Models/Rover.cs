using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Models
{
    public class Rover
    {
        public Direction Direction { get; set; }
        public int XLocation { get; set; }
        public int YLocation { get; set; }
    }
}
