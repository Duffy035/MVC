using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_Labb2.Models
{
    public class TjugoEttModels
    {
        public static int CurrentNumber { get; set; }

        public static void SetStartPlayer()
        {
            if (RandomNumber() == 1)
            {
                CurrentNumber = RandomNumber();
            }
        }

        public static int RandomNumber()
        {
            Random randomNumber = new Random();
            return randomNumber.Next() % 2 == 0 ? 1 : 2;
        }
        public static int UpdateNumber { get; set; }

        public static void ComputerPlay()
        {
            if (CurrentNumber > 18)
            {
                CurrentNumber += 2;
            }
            else if (CurrentNumber > 10 && CurrentNumber % 2 == 0)
            {
                CurrentNumber += 2;
            }
            else
            {
                CurrentNumber += RandomNumber();
            }
        }

        public static string HandleGameResult()
        {
            string playerResult = TjugoEttModels.IsGameOver("player");
            if (playerResult.Length > 0)
            {
                CurrentNumber = 0;
                return playerResult;
            }
            TjugoEttModels.ComputerPlay();
            string computerResult = TjugoEttModels.IsGameOver("computer");
            if (computerResult.Length > 0)
            {
                CurrentNumber = 0;
                return computerResult;
            }
            return string.Empty;
        }

        public static string IsGameOver(string turn)
        {
            if (CurrentNumber >= 21)
            {
                if (turn == "player")
                    return "You won! Congratulations!";
                return "The Computer won, Better luck next time!";
            }
            return string.Empty;
        }

    }
}