using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Pieces;

namespace Chess
{
    class Field
    {
     
        private Char pieceLetter;
        private col colLetter;
        public Field(Piece newPiece)
        {
            if (newPiece != null)
            {
                this.pieceLetter = newPiece.LetterDisplay;
                this.colLetter = newPiece.Color;
            }
               
            else
                this.pieceLetter = ' ';
            
        }
        public void drawChessField(int j,int i)
        {

            if (j % 2 == 0)
                Console.BackgroundColor = i % 2 != 0 ?  ConsoleColor.Gray :  ConsoleColor.Black;
            else
                Console.BackgroundColor =  i % 2 != 0 ?  ConsoleColor.Black : ConsoleColor.Gray;
            //  Console.Write("   ");
            drawLetter();
            Console.BackgroundColor = ConsoleColor.Black;
          
        }
        private void drawLetter()
        {
            if (colLetter == col.Black)
                 Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" "+ pieceLetter + " ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
