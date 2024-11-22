//Tina Moon Project 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Survey
{
    public class DisplayAnswers
    {
        List<String> SurveyResult = new List<String>();
        
        public string ConvertAns1(List<int> questionList)
        {
            SurveyResult.Clear();
            for (int i = 0; i < questionList.Count; i++)
            {
                if (questionList[i] == 5)
                {
                    SurveyResult.Insert(i, "Strongly Agree");
                }
                else if (questionList[i] == 4)
                {
                    SurveyResult.Insert(i, "Agree");
                }
                else if (questionList[i] == 3)
                {
                    SurveyResult.Insert(i, "Neutral");
                }
                else if (questionList[i] == 2)
                {
                    SurveyResult.Insert(i, "Disagree");
                }
                else if (questionList[i] == 1)
                {
                    SurveyResult.Insert(i, "Strongly Disagree");
                }
                else {
                    SurveyResult.Insert(i, "You did not answer this question. It was not counted for the total grade.");
                }
            }
            return Display(SurveyResult);
            
        }

        public string  Display(List<String> SurveyResult) {
            string hold ="";
            for (int x = 0; x < SurveyResult.Count; x++)
            {
                int qNum = x + 1;
                hold += "Question" + qNum + ": " + SurveyResult[x] + "<br>" + "<br>";
            }
            return hold;

        }
        
    }
}