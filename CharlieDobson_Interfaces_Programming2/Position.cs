using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieDobson_Interfaces_Programming2
{
    internal class Position
    {
        public int _xPos;
        public int _yPos;

        public int _maxWidth = 30;
        public int _maxHeight = 10;

        public Position(int xPos, int yPos)
        {
            _xPos = xPos;
            _yPos = yPos;
        }
    }
}
