using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_Interfaces_Programming2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
             Player _player = new Player(playerPosition: new Position(10, 10), color: ConsoleColor.Blue);
             Enemy _enemy = new Enemy(enemyPosition: new Position(0, 10), enemyColor: ConsoleColor.DarkRed);

            char _enemyChar;

            while(true)
            {
                _enemyChar = Console.ReadKey().KeyChar;

                if(_enemyChar == 'm')
                {
                    _enemy.Move();
                    
                }
                if(_enemyChar == 'i' || _enemyChar == 'o' || _enemyChar == 'p')
                {
                    _enemy._enemyState = _enemyChar;
                    _enemy.ChangeMovementStragety();
                }

                Console.SetCursorPosition(_player._playerPosition._xPos, _player._playerPosition._yPos);
                Console.ForegroundColor = _player._playerColor;
                Console.Write("*");

                Console.SetCursorPosition(_enemy._enemyPosition._xPos, _enemy._enemyPosition._yPos);
                Console.ForegroundColor = _enemy._enemyColor;
                Console.Write("*");
            }
        }

    }
}
