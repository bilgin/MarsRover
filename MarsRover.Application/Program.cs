using MarsRover.Business;
using MarsRover.Business.Contracts;
using MarsRover.Models.ComplexTypes;
using MarsRover.Models.Enums;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRover.Application
{
    class Program
    {
        private static IRoverService _roverService;
        private static IMovingService _movingService;
        private static IPlateauService _plateauService;
        static void Main(string[] args)
        {
            Startup();

            var plateau = _plateauService.Create(5, 5);
            plateau.Rovers.Add(_roverService.Initialize(new RoverPositionModel(1, 2, (Direction)'N')));
            plateau.Rovers.Add(_roverService.Initialize(new RoverPositionModel(3, 3, (Direction)'E')));
            _movingService.ExecuteCommand(plateau.Rovers[0], "LMLMLMLMM");
            _movingService.ExecuteCommand(plateau.Rovers[1], "MMRMMRMRRM");

            Console.WriteLine($"Rover 1 : X coordinat : {plateau.Rovers[0].XLocation} | Y coordinat : {plateau.Rovers[0].YLocation} | Direction : {plateau.Rovers[0].Direction}");
            Console.WriteLine($"Rover 2 : X coordinat : {plateau.Rovers[1].XLocation} | Y coordinat : {plateau.Rovers[1].YLocation} | Direction : {plateau.Rovers[1].Direction}");

            Console.ReadLine();
        }

        private static ServiceProvider Startup()
        {
            ServiceProvider serviceProvider = new ServiceCollection()
          .AddSingleton<IRoverService, RoverManager>()
          .AddSingleton<IMovingService, MovingManager>()
          .AddSingleton<IPlateauService, PlateauManager>()
          .AddSingleton<ICommandService, CommandManager>()
          .BuildServiceProvider();


            _roverService = serviceProvider.GetService<IRoverService>();
            _plateauService = serviceProvider.GetService<IPlateauService>();
            _movingService = serviceProvider.GetService<IMovingService>();

            return serviceProvider;
        }
    }
}
