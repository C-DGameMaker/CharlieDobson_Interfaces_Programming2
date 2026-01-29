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

        public void Move(Player player)
        {
            if(_movementStragety == MovementStragety.aggresive)
            {
                int _xFromPlayer = _enemyPosition._xPos - player._playerPosition._xPos;
                int _yFromPlayer = _enemyPosition._yPos - player._playerPosition._yPos;

                if(_xFromPlayer > _yFromPlayer && _xFromPlayer > 0 && _yFromPlayer > 0)
                {
                    if(_enemyPosition._xPos + 1 < 10)
                    {
                        _enemyPosition._xPos++;
                    }
                }
                else if(_xFromPlayer < _yFromPlayer && _xFromPlayer > 0 && _yFromPlayer > 0)
                {
                    if(_enemyPosition._yPos + 1 < 10)
                    {
                        _enemyPosition._yPos++;
                    }
                    
                }
                else
                {
                    if (_xFromPlayer > _yFromPlayer )
                    {
                        if (_enemyPosition._yPos - 1 > 0)
                        {
                            _enemyPosition._yPos--;
                        }
                    }
                    else if (_xFromPlayer < _yFromPlayer)
                    {
                        if (_enemyPosition._xPos - 1 > 0)
                        {
                            _enemyPosition._xPos--;
                        }
                    }
                }
            }
            else if(_movementStragety == MovementStragety.passive)
            {
                int _xFromPlayer = _enemyPosition._xPos - player._playerPosition._xPos;
                int _yFromPlayer = _enemyPosition._yPos - player._playerPosition._yPos;

                if (_xFromPlayer < _yFromPlayer && _xFromPlayer > 0 && _yFromPlayer > 0)
                {
                    if (_enemyPosition._xPos + 1 < 10)
                    {
                        _enemyPosition._xPos++;
                    }
                }
                else if (_xFromPlayer > _yFromPlayer && _xFromPlayer > 0 && _yFromPlayer > 0)
                {
                    if (_enemyPosition._yPos + 1 < 10)
                    {
                        _enemyPosition._yPos++;
                    }

                }
                else
                {
                    if (_xFromPlayer < _yFromPlayer)
                    {
                        if (_enemyPosition._yPos - 1 > 0)
                        {
                            _enemyPosition._yPos--;
                        }
                    }
                    else if (_xFromPlayer > _yFromPlayer)
                    {
                        if (_enemyPosition._xPos - 1 > 0)
                        {
                            _enemyPosition._xPos--;
                        }
                    }
                }
            }
            else if(_movementStragety == MovementStragety.random)
            {
                int direction = _random.Next(1,5);

                if(direction == 1)
                {
                    int _xDirection = _enemyPosition._xPos + 1;

                    if(_xDirection <= 10)
                    {
                        _enemyPosition._xPos++;
                    }
                }
                else if(direction == 2)
                {
                    int _xDirection = _enemyPosition._xPos - 1;

                    if (_xDirection >= 0)
                    {
                        _enemyPosition._xPos--;
                    }
                }
                else if(direction == 3)
                {
                    int _yDirection = _enemyPosition._yPos + 1;

                    if (_yDirection <= 10)
                    {
                        _enemyPosition._yPos++;
                    }
                }
                else if(direction == 4)
                {
                    int _yDirection = _enemyPosition._yPos - 1;

                    if (_yDirection >= 0)
                    {
                        _enemyPosition._yPos++;
                    }
                }
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
