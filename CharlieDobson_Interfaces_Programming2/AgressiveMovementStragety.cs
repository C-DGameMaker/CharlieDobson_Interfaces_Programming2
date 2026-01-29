using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_Interfaces_Programming2
{
    internal class AgressiveMovementStragety : IMoveStragety
    {

        Position _player;
        public AgressiveMovementStragety(Position _playerPosition)
        {
            _player = _playerPosition;
        }
        public Position Move(Position position)
        {
            if(position._xPos > _player._xPos && position._yPos > _player._yPos)
            {
                int xFromPlayer = position._xPos - _player._xPos;
                int yFromPlayer = position._xPos - _player._yPos;

                if(xFromPlayer > yFromPlayer)
                {
                    if(position._xPos - 1 >= 0)
                    {
                        position._xPos--;
                    }
                }
                else
                {
                    if(position._yPos - 1 >= 0)
                    {
                        position._yPos--;
                    }
                }
            }
            else if(position._xPos > _player._xPos)
            {
                if (position._xPos - 1 >= 0)
                {
                    position._xPos--;
                }
            }
            else if(position._yPos > _player._yPos)
            {
                if (position._yPos - 1 >= 0)
                {
                    position._yPos--;
                }
            }
            else
            {
                int xFromPlayer = _player._xPos - position._xPos;
                int yFromPlayer = _player._xPos - position._yPos;

                if (xFromPlayer < yFromPlayer)
                {
                    if (position._xPos + 1 <= 30)
                    {
                        position._xPos++;
                    }
                }
                else
                {
                    if (position._yPos + 1 <= 10)
                    {
                        position._yPos++;
                    }
                }
            }

                return position;
        }
    }
}
