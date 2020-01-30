using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business.Contracts
{
    public interface IMovingService
    {
        Rover ExecuteCommand(Rover rover, string movingCommand);
    }
}
