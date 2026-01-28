using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_Interfaces_Programming2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Position _playerPosition = new Position(10, 10);
            Player _player = new Player(playerPosition: _playerPosition, color: ConsoleColor.Blue);

            Console.SetCursorPosition(_playerPosition._xPos, _playerPosition._yPos);
            Console.ForegroundColor = _player._playerColor;
            Console.Write("*");
        }
    }
}
