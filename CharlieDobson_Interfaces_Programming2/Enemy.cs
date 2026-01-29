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

        public IMoveStragety moveStragety;

       

    }
}
