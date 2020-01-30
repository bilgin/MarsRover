using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business.Contracts
{
    public interface ICommand
    {
        void Execute(Rover rover);
    }
}
