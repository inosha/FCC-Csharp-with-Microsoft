/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/

/* output

Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.8    A       92 (3.6 pts)
Andrew          89.6            91.2    A-      89 (1.6 pts)
Emma            85.6            90.4    A-      85 (4.8 pts)
Logan           91.2            93      A       91 (1.8 pts)
*/

int numberOfExams = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumOfExams = 0;

    decimal averageOfExams = 0;

    decimal finalNumericScore = 0;

    decimal extraCreditScore = 0;

    decimal extraCreditPoint = 0;

    int gradedAssignments = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= numberOfExams)
        {
            // sumAssignmentScores += score;
            sumOfExams += score;
        }

        else
        {
            // sumAssignmentScores += score / 10;
            extraCreditScore += score / 10;
        }
    }

    averageOfExams = (decimal)(sumOfExams) / numberOfExams;
    finalNumericScore = (decimal)(sumOfExams + extraCreditScore) / numberOfExams;
    extraCreditPoint = (decimal)(extraCreditScore) / numberOfExams;

    if (finalNumericScore >= 97)
        currentStudentLetterGrade = "A+";

    else if (finalNumericScore >= 93)
        currentStudentLetterGrade = "A";

    else if (finalNumericScore >= 90)
        currentStudentLetterGrade = "A-";

    else if (finalNumericScore >= 87)
        currentStudentLetterGrade = "B+";

    else if (finalNumericScore >= 83)
        currentStudentLetterGrade = "B";

    else if (finalNumericScore >= 80)
        currentStudentLetterGrade = "B-";

    else if (finalNumericScore >= 77)
        currentStudentLetterGrade = "C+";

    else if (finalNumericScore >= 73)
        currentStudentLetterGrade = "C";

    else if (finalNumericScore >= 70)
        currentStudentLetterGrade = "C-";

    else if (finalNumericScore >= 67)
        currentStudentLetterGrade = "D+";

    else if (finalNumericScore >= 63)
        currentStudentLetterGrade = "D";

    else if (finalNumericScore >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    // Student         Grade
    // Sophia:         92.2    A-

    // int intavgofexams = (int)averageOfExams ;

    Console.WriteLine($"{currentStudent}\t\t{averageOfExams}\t\t{finalNumericScore}\t{currentStudentLetterGrade}\t{(int)(averageOfExams)} ({extraCreditPoint} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
