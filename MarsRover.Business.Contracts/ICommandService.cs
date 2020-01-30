using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business.Contracts
{
    public interface ICommandService
    {
        ICommand Generate(Movement movement);
    }
}
