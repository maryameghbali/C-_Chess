﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class King:Piece
    {
     
        public King(col color)
        {
            Color = color;
            LetterDisplay = 'K';
        }
    }
}
