using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business.Contracts
{
    public interface IPlateauService
    {
        Plateau Create(int width, int height);
    }
}
