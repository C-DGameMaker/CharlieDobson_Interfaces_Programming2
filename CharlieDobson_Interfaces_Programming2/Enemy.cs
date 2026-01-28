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
        Position _enemyPosition;

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

        MovementStragety _movementStraety;

        public void Move()
        {
            if(_movementStraety == MovementStragety.aggresive)
            {

            }
            else if(_movementStraety == MovementStragety.passive)
            {

            }
            else if(_movementStraety == MovementStragety.random)
            {

            }
        }

    }
}
