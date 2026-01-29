using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_Interfaces_Programming2
{
    internal class RandomMovementStragety : IMoveStragety
    {

        Random _random = new Random();
        public Position Move(Position position)
        {

            int direction = _random.Next(1, 5);
            int _xDirection;
            int _yDirection;

            if (direction == 1)
            {
                 _xDirection = position._xPos + 1;

                if (_xDirection <= 10)
                {
                    position._xPos++;
                }
            }
            else if (direction == 2)
            {
                 _xDirection = position._xPos - 1;

                if (_xDirection >= 0)
                {
                    position._xPos--;
                }
            }
            else if (direction == 3)
            {
                 _yDirection = position._yPos + 1;

                if (_yDirection <= 10)
                {
                    position._yPos++;
                }
            }
            else if (direction == 4)
            {
                 _yDirection = position._yPos - 1;

                if (_yDirection >= 0)
                {
                    position._yPos++;
                }
            }

            return position;
        }
    }
}
