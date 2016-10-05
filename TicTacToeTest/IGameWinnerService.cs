using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeTest
{
    public interface IGameWinnerService
    {
        char Validate(char[,] board);
    }
}
