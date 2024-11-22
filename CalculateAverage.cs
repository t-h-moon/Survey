//Tina Moon Project 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Survey
{
    public class CalculateAverage
{
        public string CalculateScore(List<int> CourseList)
        {
            double totalNum = 0.0;
            int answeredNum = CourseList.Count;
            for (int i = 0; i < CourseList.Count; i++)
            {
                if (CourseList[i] == 5)
                {
                    totalNum += 5;
                }
                else if (CourseList[i] == 4)
                {
                    totalNum += 4;
                }
                else if (CourseList[i] == 3)
                {
                    totalNum += 3;
                }
                else if (CourseList[i] == 2)
                {
                    totalNum += 2;
                }
                else if (CourseList[i] == 1)
                {
                    totalNum += 1; ;
                }
                else {
                    totalNum += 0;
                    answeredNum -= 1;
                }

            }
            double ave = (totalNum / (answeredNum* 5)) * 100;

            string letterGrade = ave + "%   " + Grade(ave).ToString();
            return letterGrade;
        }

        private string Grade(double ave)
        {
            string letter = "";
            if (ave <= 100 && ave >= 90)
            {
                letter = "A";
            }
            if (ave <= 89 && ave >= 80)
            {
                letter = "B";
            }
            if (ave <= 79 && ave >= 70)
            {
                letter = "C";
            }
            if (ave <= 69 && ave >= 60)
            {
                letter = "D";
            }
            if (ave <= 69 && ave >= 0)
            {
                letter = "F";
            }
            return letter;
        }

    }
}