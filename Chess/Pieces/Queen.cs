﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Queen:Piece
    {

        public Queen(col color)
        {
           Color = color;
            LetterDisplay = 'Q';
        }
    }
}
