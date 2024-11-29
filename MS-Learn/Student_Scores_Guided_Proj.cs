using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScoreSum = new int[5];
decimal studentScore;
string studentGrade;
int tracker;

Console.WriteLine("Student\t\tGrade\n");


foreach (string names in studentNames)
{
    tracker = 0;
    studentScore = 0;
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
    else if (names == "Logan")
    {
        studentScoreSum = loganScores;
    }
    else if (names == "Becky")
    {
        studentScoreSum = beckyScores;
    }
    else if (names == "Chris")
    {
        studentScoreSum = chrisScores;
    }
    else if (names == "Eric")
    {
        studentScoreSum = ericScores;
    }
    else
    {
        studentScoreSum = gregorScores;
    }

    foreach (int score in studentScoreSum)
    {
        tracker += 1;
        if (tracker <= 5)
        {
            studentScore += score;
        }
        else
        {
            studentScore += score / 10;
        }

    }

    studentScore = studentScore / currentAssignments;

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
    Console.WriteLine($"{names}\t\t{studentScore}\t{studentGrade}");

}
