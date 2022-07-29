using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MoodAnalyser_Day20
{
    public class MoodAnalyser
    {
        public string message;


        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            if (message.Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }

    }
}