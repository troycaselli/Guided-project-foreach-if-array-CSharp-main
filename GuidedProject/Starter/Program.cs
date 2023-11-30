using System;

// initialize variables - graded assignments 
int totalAssignments = 5;

int[] sophiaScores = new int[] {90, 86, 87, 98, 100};
int[] andrewScores = new int[] {92, 89, 81, 96, 90};
int[]  emmaScores = new int[] {90, 85, 87, 98, 68};
int[] loganScores = new int[] {90, 95, 87, 88, 96};

string[] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};
int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade\n");

// iterate through each student to print grades to console
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else
        studentScores = loganScores;

        int scoresSum = 0;
        foreach (int score in studentScores)
        {
            scoresSum += score;
        }

        decimal studentScore = (decimal)scoresSum / totalAssignments;
        Console.WriteLine(currentStudent + ":\t\t" + studentScore);

    // int andrewSum = 0;
    // int emmaSum = 0;
    // int loganSum = 0;

    // decimal andrewScore;
    // decimal emmaScore;
    // decimal loganScore;

    // foreach (int score in andrewScores)
    // {
    //     andrewSum += score;
    // }
    // foreach (int score in emmaScores)
    // {
    //     emmaSum += score;
    // }
    // foreach (int score in loganScores)
    // {
    //     loganSum += score;
    // }

    // andrewScore = (decimal)andrewSum / currentAssignments;
    // emmaScore = (decimal)emmaSum / currentAssignments;
    // loganScore = (decimal)loganSum / currentAssignments;

    // Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
    // Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
    // Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");
}



Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();
