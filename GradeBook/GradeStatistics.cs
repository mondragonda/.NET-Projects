using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class GradeStatistics
    {
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if(Math.Round(AverageGrade) >= 90)
                {
                    result = "A";
                }
                else if(Math.Round(AverageGrade) >= 80)
                {
                    result = "B";
                }
                else if(Math.Round(AverageGrade) >= 70)
                {
                    result = "C";
                }
                else if(Math.Round(AverageGrade) >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }

                return result;
            }
        }

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excelent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
                        break;
                    default:
                        result = "Failed";
                        break;
                    
                }

                return result;
            }

              
        }
    }   
}
