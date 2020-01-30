using MarsRover.Business.Contracts;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business
{
    public class PlateauManager : IPlateauService
    {
        public Plateau Create(int width, int height)
        {
            return new Plateau { Width = width, Height = height };
        }
    }
}
