using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Algorithms
{
    public class ChessQueen
    {
        private int count = 0;

        public int[] PlaceQueen(int n)
        {
            int[] columns = new int[n];
            this.count = 0;
            var result = PlaceQueenInternal(n, 0, columns);
            Debug.WriteLine("Recursive count:{0}", count);

            if (result)
            {
                return columns;
            }

            return null;
        }

        private bool PlaceQueenInternal(int n, int row, int[] columns)
        {
            Debug.Write(String.Format("row: {0} col: ", row));
            for (int i = 0; i < row; i++)
            {
                Debug.Write(String.Format(" ({0},{1})", i, columns[i]));
            }
            Debug.WriteLine("");

            count++;

            if (row == n)
            {
                return true;
            }

            for (int col = 0; col < n; col++)
            {
                bool ok = true;

                for (int i = row - 1; i >= 0; i--)
                {
                    if (i - columns[i] == row - col || i + columns[i] == row + col
                        || col == columns[i])
                    {
                        ok = false;
                        break;
                    }
                }

                if (ok)
                {
                    columns[row] = col;
                    if (PlaceQueenInternal(n, row + 1, columns))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
