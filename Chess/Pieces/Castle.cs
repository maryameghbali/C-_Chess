using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Castle:Piece
    {
       
        public Castle(col color)
        {
            Color = color;
            LetterDisplay = 'C';
        }

      
    }
}
