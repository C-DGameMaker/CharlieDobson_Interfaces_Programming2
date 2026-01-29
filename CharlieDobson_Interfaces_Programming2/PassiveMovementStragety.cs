using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_Interfaces_Programming2
{
    internal class PassiveMovementStragety : IMoveStragety
    {
        Position _player;
        public PassiveMovementStragety(Position _playerPosition)
        {
            _player = _playerPosition;
        }
        public Position Move(Position position)
        {
            int _xFromPlayer = position._xPos - _player._xPos;
            int _yFromPlayer = position._yPos - _player._yPos;

            if (_xFromPlayer < _yFromPlayer && _xFromPlayer > 0 && _yFromPlayer > 0)
            {
                if (position._xPos + 1 <= 30)
                {
                    position._xPos++;
                }
            }
            else if (_xFromPlayer > _yFromPlayer && _xFromPlayer > 0 && _yFromPlayer > 0)
            {
                if (position._yPos + 1 <= 10)
                {
                    position._yPos++;
                }

            }
            else
            {
                if (_xFromPlayer < _yFromPlayer)
                {
                    if (position._yPos - 1 >= 0)
                    {
                        position._yPos--;
                    }
                }
                else if (_xFromPlayer > _yFromPlayer)
                {
                    if (position._xPos - 1 >= 0)
                    {
                        position._xPos--;
                    }
                }
            }
            return position;
        }
    }
}
