using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Checkers
{
    public class Game
    {
        public Color Turn = Color.Red;

        public Checker[,] Board = new Checker[8,8];

        public Game()
        {

            for (int j = 0; j < 8; j += 2)
            {
                Board[j, 0] = new Checker(Color.Black);
                Board[j+1, 1] = new Checker(Color.Black);
                Board[j, 2] = new Checker(Color.Black);

                Board[j+1, 7] = new Checker(Color.Red);
                Board[j, 6] = new Checker(Color.Red);
                Board[j+1, 5] = new Checker(Color.Red);
            }
        }

        public string Serialize()
        {
            string state = "";
            state += Turn.ToString() + "\n";
            for (int y = 0; y < 8; y++)
            {
                for(int x = 0; x<8; x++)
                {
                    if(Board[x,y]!=null)
                    {
                        Checker checker = Board[x, y];
                        state += $"{checker.Color}, {checker.King}, {x}, {y}\n";
                    }
                }
            }

            return state;
        }
    }
}
