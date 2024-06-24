using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Enums;
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
            (int x, int y) = GetIndex(pb, Form1.GameSize);
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
                                                       IsValidLine(pb, pbs, (x, y) => ((x + 1) % Form1.GameSize, y));


        public static bool IsValidHorizontalLine(PictureBox pb, PictureBox[,] pbs) =>
                                                        IsValidLine(pb, pbs, (x, y) => (x, (y + 1) % Form1.GameSize));
        public static bool IsValidNormalDiagonal(PictureBox pb, PictureBox[,] pbs)
        {
            (int i, int j) = GetIndex(pb, Form1.GameSize);
            if (i != j)
                return false;
            return IsValidLine(pb, pbs, (x, y) => ((x + 1) % Form1.GameSize, (y + 1) % Form1.GameSize));
        }
        public static bool IsValidAntiDiagonal(PictureBox pb, PictureBox[,] pbs)
        {
            (int i, int j) = GetIndex(pb, Form1.GameSize);
            if (i + j !=Form1.GameSize-1)
                return false;
            return IsValidLine(pb, pbs, (x, y) => (((x - 1) % Form1.GameSize + Form1.GameSize) % Form1.GameSize, (y + 1) % Form1.GameSize));
        }
        public static GridColoringType CheckGame(PictureBox pb, PictureBox[,] pbs)
        {
            if (IsValidVerticalLine(pb, pbs))
                return GridColoringType.Vertical;
            if (IsValidHorizontalLine(pb, pbs))
                return GridColoringType.Horizontal;
            if (IsValidNormalDiagonal(pb, pbs))
                return GridColoringType.Diagonal;
            if (IsValidAntiDiagonal(pb, pbs))
                return GridColoringType.AntiDiagonal;
            return GridColoringType.None;
        }

    }
}
