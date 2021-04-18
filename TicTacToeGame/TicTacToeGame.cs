using System;

namespace TicTacToeGame
{
    public class TicTacToeGame
    {
        /// <summary>
        /// null - clear, true - X, false - 0
        /// </summary>
        private bool?[,] _desk = new bool?[3,3];
        private bool? _turnX;
        private bool _finished;
        
        public void Start()
        {
            ClearDesk();
            _turnX = null;
        }

        public bool TurnX(int row, int column)
        {

        }

        private void ClearDesk()
        {
            for (var i = 0; i < 3; ++i)
                for (var j = 0; j < 3; ++j)
                {
                    _desk[i, j] = null;
                }
        }
    }
}
