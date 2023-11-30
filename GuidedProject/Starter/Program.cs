using System;

// initialize variables - graded assignments 
int totalAssignments = 5;

int[] sophiaScores = new int[] {90, 86, 97, 98, 100};
int[] andrewScores = new int[] {92, 89, 81, 96, 90};
int[]  emmaScores = new int[] {70, 85, 87, 84, 68};
int[] loganScores = new int[] {90, 95, 87, 88, 96};

string[] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};
int[] studentScores = new int[10];

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
    else
        studentScores = loganScores;

    // find average student score
    int scoresSum = 0;
    foreach (int score in studentScores)
    {
        scoresSum += score;
    }
    decimal studentScore = (decimal)scoresSum / totalAssignments;

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
