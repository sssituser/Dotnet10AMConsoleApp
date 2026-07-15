using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticProject
{
    internal class Cricket
    {
       static int TotalScore=0;
        int PersonalScore=0;

        public void ShowTotalScore()
        {
            Console.WriteLine($"Total Score is : {TotalScore}");
        }
        public void ShowPeronalScore(int PersonalScore)
        {
            this.PersonalScore = PersonalScore;
            Console.WriteLine($"Personal Score : {this.PersonalScore}");
            TotalScore += this.PersonalScore;
        }

    }
}
