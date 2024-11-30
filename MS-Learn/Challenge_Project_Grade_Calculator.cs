using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan"};
int[] studentScoreSum = new int[5];
decimal studentScore;
string studentGrade;
decimal studentScore_WithoutCredit;
int tracker;
int credit_avg;
decimal credit_points_actual;

Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

foreach (string names in studentNames)
{
    tracker = 0;
    studentScore = 0;
    credit_avg = 0;
    studentScore_WithoutCredit = 0;
    credit_points_actual = 0;
    if (names == "Sophia")
    {
        studentScoreSum = sophiaScores;
    }
    else if (names == "Andrew")
    {
        studentScoreSum = andrewScores;
    }
    else if (names == "Emma")
    {
        studentScoreSum = emmaScores;
    }
    else
    {
        studentScoreSum = loganScores;
    }
    


    foreach (int score in studentScoreSum)
    {
        tracker += 1;
        if (tracker <= 5)
        {
            studentScore += score;
            studentScore_WithoutCredit += score;
        }
        else
        {
            credit_points_actual += score;
        }

    }

    studentScore_WithoutCredit = studentScore_WithoutCredit / currentAssignments;
    credit_avg = (int)credit_points_actual / (tracker - 5);
    credit_points_actual = credit_points_actual / 50;
    studentScore = studentScore_WithoutCredit + credit_points_actual;

    if (studentScore > 97)
    {
        studentGrade = "A+";
    }
    else if (studentScore >= 93)
    {
        studentGrade = "A";
    }
    else if (studentScore >= 90)
    {
        studentGrade = "A-";
    }
    else if (studentScore >= 87)
    {
        studentGrade = "B+";
    }
    else if (studentScore >= 83)
    {
        studentGrade = "B";
    }
    else if (studentScore >= 80)
    {
        studentGrade = "B-";
    }
    else if (studentScore >= 77)
    {
        studentGrade = "C+";
    }
    else if (studentScore >= 73)
    {
        studentGrade = "C";
    }
    else if (studentScore >= 70)
    {
        studentGrade = "C-";
    }
    else if (studentScore >= 67)
    {
        studentGrade = "D+";
    }
    else if (studentScore >= 63)
    {
        studentGrade = "D";
    }
    else if (studentScore >= 60)
    {
        studentGrade = "D-";
    }
    else
    {
        studentGrade = "F";
    }
    Console.WriteLine($"{names}\t\t{studentScore_WithoutCredit}\t\t{studentScore}\t{studentGrade}\t{credit_avg}({credit_points_actual}pts)");

}
