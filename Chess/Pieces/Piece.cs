using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
     class Piece
    {
        private char letterDisplay;
        private col color;
        protected bool hasBeenMoved = false;

        public char LetterDisplay { get => letterDisplay; set => letterDisplay = value; }
        public col Color { get => color; set => color = value; }

        public override string ToString()
        {
            return LetterDisplay.ToString();
        }

    }
}
