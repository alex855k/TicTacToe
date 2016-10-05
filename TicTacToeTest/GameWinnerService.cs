using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeTest
{
    class GameWinnerService : IGameWinnerService
    {

        public char[,] gameBoard = new char[3, 3] { {' ', ' ', ' ' },
                                                 {' ', ' ', ' ' },
                                                 {' ', ' ', ' ' } };


        public char CheckForThreeInARowHorizontalRow(char[,] gameBoard) {

            var columnOneChar = gameBoard[0, 0];
            var columnTwoChar = gameBoard[0, 1];
            var columnThreeChar = gameBoard[0, 2];
            if (columnOneChar == columnTwoChar &&
                columnTwoChar == columnThreeChar)
            {
                return columnOneChar;
            }
            return ' ';
        }

        public char Validate(char[,] board)
        {

            var currentWinningSymbol = ' ';
           
            currentWinningSymbol = this.CheckForThreeInARowHorizontalRow(board);
      
            if(currentWinningSymbol != ' ') {
                return currentWinningSymbol;
            }
            currentWinningSymbol = this.CheckForThreeInARowVerticalColumn(board);
            return currentWinningSymbol;
        }

        private char CheckForThreeInARowVerticalColumn(char[,] board)
        {
            var rowOneChar = board[0, 0];
            var rowTwoChar = board[1, 0];
            var rowThreeChar = board[2, 0];
            if (rowOneChar == rowTwoChar &&
                rowTwoChar == rowThreeChar)
            {
                return rowOneChar;
            }
            return ' ';
        }
    }
}
