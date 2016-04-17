using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIVALACODE
{
    public static class Tennis
    {
        public static string say(int i, int j)
        {
            string[] point = { "Love", "Fifteen", "Thirty", "Forty" };

            if (i == j)
            {
                if (i >= 3)
                {
                    return "Deuce";
                }
                else
                {
                    return point[i] + " " + "All";
                }
            }
            else
            {
                return "Fifteen Love";
            }
        }
    }
}