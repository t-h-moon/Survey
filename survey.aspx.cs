//Tina Moon Project 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Survey
{
    public partial class survey : System.Web.UI.Page
    {
        List<string> NeedToParseCourse = new List<string>();
        List<string> NeedToParseIns = new List<string>();
        List<int> CourseList = new List<int>();
        List<int> InstructorList = new List<int>();

        //This method will parse the string numbers into int
        private void ParseCourse(List<string> stringList) {
            for (int i = 0; i < stringList.Count; i++)
            {
                if (NeedToParseCourse[i] == null || stringList[i] == "")//for no input for radio
                {
                    NeedToParseCourse[i] = "0";
                    CourseList.Add(Int32.Parse(stringList[i]));
                }
                else
                {
                    CourseList.Add(Int32.Parse(stringList[i]));
                }
            }
        }


        private void ParseInt(List<string> stringList)
        {
            for (int i = 0; i < stringList.Count; i++)
            {
                if (NeedToParseIns[i] == null || stringList[i] == "")
                {
                    NeedToParseIns[i] = "0";
                    InstructorList.Add(Int32.Parse(stringList[i]));
                }
                else
                {
                    InstructorList.Add(Int32.Parse(stringList[i]));
                }
            }
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {   //adding all the HTML values into var to put into List 
                String StudentFName = Request["txtStudentFName"];
                String StudentLName = Request["txtStudentLName"];
                String StudentId = Request["txtStudentID"];
                String StudentCourse = Request["ddlStudentCourse"];
                String q1 = Request["question1"];
                String q2 = Request["question2"];
                String q3 = Request["question3"];
                String q4 = Request["question4"];
                String q5 = Request["question5"];
                String q6 = Request["question6"];
                String q7 = Request["question7"];
                String q8 = Request["question8"];
                String q9 = Request["question9"];
                String q10 = Request["question10"];
                String q11 = Request["question11"];
                String q12 = Request["question12"];
                String q13 = Request["question13"];
                String q14 = Request["question14"];
                String q15 = Request["question15"];
                String q16 = Request["question16"];
                String q17 = Request["question17"];
                String q18 = Request["question18"];
                String q19 = Request["question19"];
                String q20 = Request["question20"];

                //adding the staring vars into List 
                NeedToParseCourse.Add(q1);
                NeedToParseCourse.Add(q2);
                NeedToParseCourse.Add(q3);
                NeedToParseCourse.Add(q4);
                NeedToParseCourse.Add(q5);
                NeedToParseCourse.Add(q6);
                NeedToParseCourse.Add(q7);
                NeedToParseCourse.Add(q8);
                NeedToParseCourse.Add(q9);
                NeedToParseCourse.Add(q10);
                NeedToParseCourse.Add(q11);
                NeedToParseCourse.Add(q12);
                NeedToParseIns.Add(q13);
                NeedToParseIns.Add(q14);
                NeedToParseIns.Add(q15);
                NeedToParseIns.Add(q16);
                NeedToParseIns.Add(q17);
                NeedToParseIns.Add(q18);
                NeedToParseIns.Add(q19);
                NeedToParseIns.Add(q20);

                //calling methods that will  parse the string int
                ParseCourse(NeedToParseCourse);
                ParseInt(NeedToParseIns);

                //displaying and calling methods
                lblThanks.Text = "Thank you, " + StudentFName + " for filling out the Student Feedback Form!";

                lblDisplay.Text = "Student Name: " + StudentFName +" " + StudentLName + "<br>" + "Student TUID: " + StudentId + "<br>"
                   + "Student Course: " + StudentCourse + "<br>";

                CalculateAverage score = new CalculateAverage();
                string courseScore = score.CalculateScore(CourseList);
                string instructorScore = score.CalculateScore(InstructorList);

                DisplayAnswers courseAns = new DisplayAnswers();
                string ConvertAns1 = courseAns.ConvertAns1(CourseList);
                string ConvertAns2 = courseAns.ConvertAns1(InstructorList);

                lblAnswers.Text = ConvertAns1;
                lblAnswers2.Text = ConvertAns2;

                lblCalculate.Text = "Course Score: " + courseScore.ToString() + "<br>"
                    + "Instructor Score: " + instructorScore.ToString();
            }
        }
    }
}