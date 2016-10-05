using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToeTest
{
    [TestClass]
    public class Test
    {

        GameWinnerService _gameWinnerService = new GameWinnerService();
    

        [TestMethod]
        public void NeitherPlayerHasThreeInARow()
        {
            const char expected = ' ';
            var gameBoard = new char[3, 3] { {' ', ' ', ' ' },
                                        {' ', ' ', ' ' },
                                        {' ', ' ', ' ' } };

            var actual = _gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void PlayerWithAllSpacesInTopRowIsWinner() {
           
            const char expected = 'X';
            var gameBoard = new char[3, 3] { { expected, expected, expected},
                                             {' ', ' ', ' '},
                                             {' ', ' ', ' '} };
            var actual = _gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void PlayerWithAllSpacesInFirstColumnIsWinner()
        {
            const char expected = 'X';
            var gameBoard = new char[3, 3] { { expected, expected, expected},
                                             {' ', ' ', ' '},
                                             {' ', ' ', ' '} };
            for (var columnIndex = 0; columnIndex < 3; columnIndex++)
            {
                gameBoard[columnIndex, 0] = expected;
            }
            var actual = _gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
