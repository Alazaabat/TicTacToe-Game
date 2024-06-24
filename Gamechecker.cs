using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    internal static class Gamechecker
    {
        public static (int, int) GetIndex(PictureBox pb, int size)
        {
            int index = pb.Name.Last() - '0' - 1;
            int x = index / size;
            int y = index % size;
            return (x, y);
        }
        public static bool IsValidLine(PictureBox pb, PictureBox[,] pbs, Func<int, int, (int, int)> nextIndex)
        {
            (int x, int y) = GetIndex(pb, Form1.gameSize);
            var lastChoice = Form1.GetPlayerChoiceFromPictureBox(pb);
            var currentChoice = lastChoice;
            int i = x;
            int j = y;
            do
            {
                (i, j) = nextIndex.Invoke(i, j);
                currentChoice = Form1.GetPlayerChoiceFromPictureBox(pbs[i, j]);
            } while (currentChoice == lastChoice && (x, y) != (i, j));
            return (x, y) == (i, j);
        }
        public static bool IsValidVerticalLine(PictureBox pb, PictureBox[,] pbs) =>
                                                       IsValidLine(pb, pbs, (x, y) => ((x + 1) % Form1.gameSize, y));


        public static bool IsValidHorizontalLine(PictureBox pb, PictureBox[,] pbs) =>
                                                        IsValidLine(pb, pbs, (x, y) => (x, (y + 1) % Form1.gameSize));
        public static bool IsValidNormalDiagonal(PictureBox pb, PictureBox[,] pbs)
        {
            (int i, int j) = GetIndex(pb, Form1.gameSize);
            if (i != j)
                return false;
            return IsValidLine(pb, pbs, (x, y) => ((x + 1) % Form1.gameSize, (y + 1) % Form1.gameSize));
        }
        public static bool IsValidAntiDiagonal(PictureBox pb, PictureBox[,] pbs)
        {
            (int i, int j) = GetIndex(pb, Form1.gameSize);
            if (i + j !=Form1.gameSize-1)
                return false;
            return IsValidLine(pb, pbs, (x, y) => (((x - 1) % Form1.gameSize + Form1.gameSize) % Form1.gameSize, (y + 1) % Form1.gameSize));
        }
        public static bool CheckGame(PictureBox pb, PictureBox[,] pbs)
        {
            if (IsValidVerticalLine(pb, pbs))
                return true;
            if (IsValidHorizontalLine(pb, pbs))
                return true;
            if (IsValidNormalDiagonal(pb, pbs))
                return true;
            if (IsValidAntiDiagonal(pb, pbs))
                return true;
            return false;
        }

    }
}
