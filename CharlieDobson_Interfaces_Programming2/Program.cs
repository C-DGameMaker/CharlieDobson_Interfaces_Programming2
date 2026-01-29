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
        public static Player _player = new Player(playerPosition: new Position(5, 5), color: ConsoleColor.Blue);
        public static Enemy _enemy = new Enemy(enemyPosition: new Position(4, 3), enemyColor: ConsoleColor.DarkRed);
        static void Main(string[] args)
        {
            AgressiveMovementStragety _agressiveMove = new AgressiveMovementStragety(_player._playerPosition);
            PassiveMovementStragety _passiveMove = new PassiveMovementStragety(_player._playerPosition);
            RandomMovementStragety _randomMove = new RandomMovementStragety();

            _enemy.moveStragety = _passiveMove;

            char _enemyChar;

            while(true)
            {
                Console.SetCursorPosition(0, 0);
                Console.Clear();
                Console.SetCursorPosition(_player._playerPosition._xPos, _player._playerPosition._yPos);
                Console.ForegroundColor = _player._playerColor;
                Console.Write("*");

                Console.SetCursorPosition(_enemy._enemyPosition._xPos, _enemy._enemyPosition._yPos);
                Console.ForegroundColor = _enemy._enemyColor;
                Console.Write("*");
                _enemyChar = Console.ReadKey().KeyChar;

                if (_enemyChar == 'm')
                {
                    _enemy._enemyPosition = _enemy.moveStragety.Move(_enemy._enemyPosition);
                }
                else if (_enemyChar == 'i')
                {
                    _enemy.moveStragety = _agressiveMove;
                }
                else if(_enemyChar == 'o')
                {
                    _enemy.moveStragety = _passiveMove;
                }
                else if(_enemyChar == 'p')
                {
                    _enemy.moveStragety = _randomMove;
                }

                

                
            }
        }

    }
}
