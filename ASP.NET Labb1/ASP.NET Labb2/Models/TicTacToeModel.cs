using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_Labb2.Models
{
    public class TicTacToeModel
    {
        public static int InitializeBoard(List<Cordiante> tiles)
        {
            int horizontal = 8;
            int vertical = 3;
            for (int i = 0; i < horizontal; i++)
            {
                for (int j = 0; j < vertical; j++)
                {
                    tiles.Add(new Cordiante {XCordiante = i, YCordiante = j, sign = ' '});
                }
            }
            for (int j = 0; j <= 8; j++)
            {
                tiles[j].ID = j;
            }
            return horizontal;
        }

        public static string CheckForWinner(char checkForWin)
        {
            if (CheckForDiagonalWin(checkForWin) || CheckForVerticalWin(checkForWin) || CheckForHorizontalWin(checkForWin))
            {
                if (checkForWin == 'X')
                {
                    ResetTile();
                    return "You are the winner!";
                }

                if (checkForWin == 'O')
                {
                    ResetTile();
                    return "You lost, the computer won...";
                }
            }
            if (CheckForTie())
            {
                ResetTile();
                return "It's a tie! No one wins!";
            }
            return String.Empty;
        }

        public static bool CheckForDiagonalWin(char checkForSign)
        {
            if (Tiles.TileCordiantes[0].sign == checkForSign && Tiles.TileCordiantes[4].sign == checkForSign && Tiles.TileCordiantes[8].sign == checkForSign)
            {
                return true;
            }
            if (Tiles.TileCordiantes[2].sign == checkForSign && Tiles.TileCordiantes[4].sign == checkForSign && Tiles.TileCordiantes[6].sign == checkForSign)
            {
                return true;
            }
            return false;

        }
        public static bool CheckForVerticalWin(char checkForSign)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Tiles.TileCordiantes[i].sign == checkForSign && Tiles.TileCordiantes[i + 3].sign == checkForSign && Tiles.TileCordiantes[i + 6].sign == checkForSign)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckForHorizontalWin(char checkForSign)
        {
            for (int i = 0; i < 9; i += 3)
            {
                if (Tiles.TileCordiantes[i].sign == checkForSign && Tiles.TileCordiantes[i + 1].sign == checkForSign && Tiles.TileCordiantes[i + 2].sign == checkForSign)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckForTie()
        {
            int counter = 0;
            foreach (var cordinate in Tiles.TileCordiantes)
            {
                if (cordinate.sign == 'O' || cordinate.sign == 'X')
                    counter++;
            }

            if (counter == 9)
                return true;
            return false;
        }
        public static int ComputerPlay()
        {
            if (Tiles.TileCordiantes[4].sign == '5')
                return 5;
            return RandomFreeSquare();
        }
        public static void ChangeCordiante(int id, char sign)
        {
            for (int i = 0; i < Tiles.TileCordiantes.Count; i++)
            {
                if (Tiles.TileCordiantes[i].ID == id)
                {
                    Tiles.TileCordiantes[i].sign = sign;
                }
            }
        }
        public static string RunGameLogic(string send)
        {
            ChangeCordiante(int.Parse(send), 'X');
            string message = CheckForWinner('X');
            if (message.Length > 0)
                return message;

            ChangeCordiante(ComputerPlay(), 'O');
            message = CheckForWinner('O');
            if (message.Length > 0)
                return message;

            message = CheckForWinner('O');
            if (message.Length > 0)
            {
                return message;
            }
            return message;
        }
        public static int RandomFreeSquare()
        {
            List<int> freeSquares = new List<int>();
            foreach (var cordinate in Tiles.TileCordiantes)
            {
                if (cordinate.sign != 'X' && cordinate.sign != 'O')
                {
                    freeSquares.Add(cordinate.ID);
                }
            }
            Random randomNr = new Random();
            int squareId = randomNr.Next(0, freeSquares.Count - 1);
            return freeSquares[squareId];
        }
        public static void ResetTile()
        {
            Tiles.TileCordiantes = new List<Cordiante>();
            for (int i = 1; i <= 9; i++)
            {
                Tiles.TileCordiantes.Add(new Cordiante() {ID = i, sign = char.Parse(i.ToString()), DisableButton = false});
            }
        }


    }
}