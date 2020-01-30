using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Models
{
    public class Plateau
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Rover> Rovers { get; set; } = new List<Rover>();
    }
}
