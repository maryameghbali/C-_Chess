using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Bishop:Piece
    {
      
        public Bishop(col color)
        {
            Color = color;
            LetterDisplay = 'B';
        }
    }
}
