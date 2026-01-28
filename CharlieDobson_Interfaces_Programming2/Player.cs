using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_Interfaces_Programming2
{
    internal class Player
    {
        public ConsoleColor _playerColor;
        Position _playerPosition;
        public Player(Position playerPosition, ConsoleColor color)
        {
            _playerPosition = playerPosition;
            _playerColor = color;

        }
    }
}
