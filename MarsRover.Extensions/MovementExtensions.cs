using MarsRover.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Extensions
{
    public static class MovementExtensions
    {
        public static List<Movement> ConvertToMovements(this List<Movement> movements, string movingCommand)
        {
            if (!string.IsNullOrEmpty(movingCommand))
            {
                char[] movingCommands = movingCommand.ToCharArray();
                Array.ForEach(movingCommands, command =>
                {
                    switch (command)
                    {
                        case (char)Movement.Right:
                            movements.Add(Movement.Right);
                            break;
                        case (char)Movement.Left:
                            movements.Add(Movement.Left);
                            break;
                        case (char)Movement.Move:
                            movements.Add(Movement.Move);
                            break;
                    }
                });
            }

            return movements;
        }
    }

}
