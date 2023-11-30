using System;

// initialize variables - graded assignments 
int examAssignments = 5;

// student scores
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };
int[] studentScores = new int[10];

// student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

// print table header
Console.WriteLine("Student\t\tScore\tGrade\n");

// iterate through each student to print grades to console
foreach (string name in studentNames)
{
    string currentStudent = name;
    string studentLetterGrade = "";

    // set student score values
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;

    // find average student score
    int scoresSum = 0;
    int gradedAssignments = 0;
    foreach (int score in studentScores)
    {
        gradedAssignments++;
        // determine weighting before adding
        if (gradedAssignments <= examAssignments)
            scoresSum += score;
        else
            scoresSum += score / 10;
    }
    decimal studentScore = (decimal)scoresSum / examAssignments;

    // determine student letter grade
    if (studentScore >= 97)
        studentLetterGrade = "A+";

    else if (studentScore >= 93)
        studentLetterGrade = "A";

    else if (studentScore >= 90)
        studentLetterGrade = "A-";

    else if (studentScore >= 87)
        studentLetterGrade = "B+";

    else if (studentScore >= 83)
        studentLetterGrade = "B";

    else if (studentScore >= 80)
        studentLetterGrade = "B-";

    else if (studentScore >= 77)
        studentLetterGrade = "C+";

    else if (studentScore >= 73)
        studentLetterGrade = "C";

    else if (studentScore >= 70)
        studentLetterGrade = "C-";

    else if (studentScore >= 67)
        studentLetterGrade = "D+";

    else if (studentScore >= 63)
        studentLetterGrade = "D";

    else if (studentScore >= 60)
        studentLetterGrade = "D-";
    else
        studentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}:\t\t{studentScore}\t{studentLetterGrade}");
}
