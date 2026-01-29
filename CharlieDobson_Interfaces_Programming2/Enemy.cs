using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_Interfaces_Programming2
{
    internal class Enemy
    {
        public ConsoleColor _enemyColor;
        public Position _enemyPosition { get; private set; }

        public Enemy(Position enemyPosition, ConsoleColor enemyColor)
        {
            _enemyPosition = enemyPosition;
            _enemyColor = enemyColor;
        }

        enum MovementStragety
        { 
            aggresive,
            passive,
            random
        };

        MovementStragety _movementStragety;
        Random _random = new Random();
        public char _enemyState;

        public void Move()
        {
            if(_movementStragety == MovementStragety.aggresive)
            {

            }
            else if(_movementStragety == MovementStragety.passive)
            {

            }
            else if(_movementStragety == MovementStragety.random)
            {
                int direction = _random.Next(1,5);
            }
        }

        public void ChangeMovementStragety()
        {
            if(_enemyState == 'i')
            {
                _movementStragety = MovementStragety.aggresive;
            }
            else if (_enemyState == 'o')
            {
                _movementStragety = MovementStragety.passive;
            }
            else if (_enemyState == 'p')
            {
                _movementStragety = MovementStragety.random;
            }
        }

    }
}
