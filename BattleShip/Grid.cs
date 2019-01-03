using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip
{
    public class Grid
    {
        public string[,] arr = new string[22, 22];

        public void MakeNewGrid()
        {
            for (int i = 0; i < 1; i++)
            {
                string[] letArr = new string[21] { "//","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T" };
                
                for (int j = 0; j < 21; j++)
                {
                    arr[i, j] = letArr[j];
                    arr[i, j] += " ";
                }
            }

            for (int i = 1; i < 21; i++)
            {
                string[] numArr = new string[21] { "//", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };

                for (int j = 0; j < 1; j++)
                {
                    arr[i, j] = numArr[i];
                    arr[i, j] += " ";
                }
            }
            
            for (int i = 1; i < 21; i++)
            {
                for (int j = 1; j < 21; j++)
                {
                    arr[i, j] = ". ";
                }
            }

            for (int i = 21; i < 22; i++)
            {
                for (int j = 0; j < 22; j++)
                {
                    arr[i, j] = " #";
                }
            }

            for (int i = 0; i < 22; i++)
            {
                for (int j = 21; j < 22; j++)
                {
                    arr[i, j] = "#";
                }
            }

            arr[21, 21] = " #";
        }

        public void DisplayGrid()
        {
            for (int i = 0; i < 22; i++)
            {
                for (int j = 0; j < 22; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
        }

    }
}