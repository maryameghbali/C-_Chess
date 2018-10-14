using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Pieces;

namespace Chess
{
    class Board
    {
        private string[] topLine = { "┌", "┬", "┐" };

        private string[] bottomLine = { "└", "┴", "┘" };

        private string[] midLine = { "─", "│", "├", "┼", "┤" };

        private Field[,] myBoard= new Field[8,8];
      //  private Field myField = new Field();
        public Board()
        {
        }

        public void drawChessBoard()
        {

            for (int i= 0; i <= 8 ; i++)
            {
                if (i == 0)
                    Console.Write(topLine[0]);
                else if (i == 8)
                {
                    Console.Write(topLine[2]);
                    break;
                }
                else
                    Console.Write(topLine[1]);
                Console.Write(midLine[0]);
                Console.Write(midLine[0]);
                Console.Write(midLine[0]);

            }
           
            for (int j = 0; j < 7; j++)
            {
                Console.WriteLine();
                Console.Write(midLine[1]);
                for (int i = 0; i < 8; i++)
                {
                    myBoard[j, i] = new Field(null);
                    if (j == 0 && (i == 0 || i==7))
                        myBoard[j, i] = new Field(new Castle(col.Black));
                    if (j == 0 && (i == 1 || i == 6))
                        myBoard[j, i] = new Field(new Knight(col.Black));
                    if (j == 0 && (i == 2 || i == 5))
                        myBoard[j, i] = new Field(new Bishop(col.Black));
                    if (j == 0 && i == 3)
                        myBoard[j, i] = new Field(new Queen(col.Black));
                    if (j == 0 && i == 4)
                        myBoard[j, i] = new Field(new King(col.Black));
                   
                 
                  
                    if (j == 1)
                        myBoard[j, i] = new Field(new Pawn(col.Black));
                    if (j == 6)
                        myBoard[j, i] = new Field(new Pawn(col.White));
                    myBoard[j, i].drawChessField(j,i);
                    Console.Write(midLine[1]);

                }
                Console.WriteLine();
                Console.Write(midLine[2]);
                for (int i = 0; i < 8; i++)
                {

                    Console.Write(midLine[0]);
                    Console.Write(midLine[0]);
                    Console.Write(midLine[0]);
                    if (i == 7)
                        Console.Write(midLine[4]);
                    else
                        Console.Write(midLine[3]);
                }
            }
            Console.WriteLine();
            Console.Write(midLine[1]);
            for (int i = 0; i < 8; i++)
            {
                myBoard[7, i] = new Field(null);
                if ((i == 0 || i == 7))
                    myBoard[7, i] = new Field(new Castle(col.Black));
                if ( (i == 1 || i == 6))
                    myBoard[7, i] = new Field(new Knight(col.Black));
                if ((i == 2 || i == 5))
                    myBoard[7, i] = new Field(new Bishop(col.Black));
                if (i == 3)
                    myBoard[7, i] = new Field(new Queen(col.Black));
                if (i == 4)
                    myBoard[7, i] = new Field(new King(col.Black));
                myBoard[7, i].drawChessField(7,i);
                Console.Write(midLine[1]);

            }
            Console.WriteLine();
            for (int i = 0; i <= 8; i++)
            {

                if (i == 0)
                    Console.Write(bottomLine[0]);
                else if (i == 8)
                {
                    Console.Write(bottomLine[2]);
                    break;
                }
                else
                    Console.Write(bottomLine[1]);
                Console.Write(midLine[0]);
                Console.Write(midLine[0]);
                Console.Write(midLine[0]);
            }

            Console.ReadKey();
        }
    }
}
