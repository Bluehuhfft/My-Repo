using System.Numerics;

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;
int sumHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

int gradeA, gradeB;
gradeA = 4;
gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalscore = course1Credit * course1Grade + course2Credit * course2Grade + course3Credit * course3Grade + course4Credit * course4Grade + course5Credit * course5Grade;
decimal gpa = (decimal)totalscore / sumHours;

// Rounding of GPA
int roundedoffgpa_1= (int) (gpa * 10) % 10; //1st digit
int roundedoffgpa_2 = (int) (gpa * 100) % 10; //2nd digit
int whole_gpa =  (int) gpa;

Console.WriteLine($"Student Name: {studentName}\n");
Console.WriteLine("Course\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t    {course1Grade}\t      {course1Credit}");
Console.WriteLine($"{course2Name}\t    {course2Grade}\t      {course2Credit}");
Console.WriteLine($"{course3Name}\t    {course3Grade}\t      {course3Credit}");
Console.WriteLine($"{course4Name}  {course4Grade}\t      {course4Credit}");
Console.WriteLine($"{course5Name}\t    {course5Grade}\t      {course5Credit}\n");
Console.WriteLine($"Final GPA: {whole_gpa}.{roundedoffgpa_1}{roundedoffgpa_2}");

