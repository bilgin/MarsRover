using MarsRover.Models;
using MarsRover.Models.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business.Contracts
{
    public interface IRoverService
    {
        Rover Initialize(RoverPositionModel roverPositionModel);
    }
}
