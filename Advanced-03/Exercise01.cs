//using System;
//using System.Collections.Generic;
////xercise 1
//class Program
//{
//    static void Main()
//    {
//        // 1. Create a collection with the given grades
//        List<int> grades = new List<int>
//        {
//            85, 92, 78, 95, 88, 70, 100, 65
//        };

//        // 2. Print the collection, Count, first and last grade
//        Console.WriteLine("Grades:");

//        foreach (int grade in grades)
//        {
//            Console.Write(grade + " ");
//        }

//        Console.WriteLine();
//        Console.WriteLine($"Count: {grades.Count}");
//        Console.WriteLine($"First Grade: {grades[0]}");
//        Console.WriteLine($"Last Grade: {grades[grades.Count - 1]}");

//        // 3. Sort the grades ascending, then print
//        grades.Sort();

//        Console.WriteLine("\nSorted Grades:");

//        foreach (int grade in grades)
//        {
//            Console.Write(grade + " ");
//        }

//        // 4. Get the first grade above 90
//        int firstAbove90 = grades.Find(grade => grade > 90);

//        Console.WriteLine($"\n\nFirst Grade Above 90: {firstAbove90}");

//        // 5. Get all grades below 75
//        List<int> failingGrades = grades.FindAll(grade => grade < 75);

//        Console.WriteLine("\nFailing Grades:");

//        foreach (int grade in failingGrades)
//        {
//            Console.Write(grade + " ");
//        }

//        // 6. Remove all failing grades
//        grades.RemoveAll(grade => grade < 75);

//        Console.WriteLine("\n\nGrades After Removing Failing Grades:");

//        foreach (int grade in grades)
//        {
//            Console.Write(grade + " ");
//        }

//        // 7. Check if any grade equals 100
//        bool has100 = grades.Contains(100);

//        Console.WriteLine($"\n\nAny Grade Equals 100? {has100}");

//        // 8. Create a List<string> where each grade becomes "Grade: X"
//        List<string> gradeLabels = new List<string>();

//        foreach (int grade in grades)
//        {
//            gradeLabels.Add($"Grade: {grade}");
//        }

//        Console.WriteLine("\nGrade Labels:");

//        foreach (string label in gradeLabels)
//        {
//            Console.WriteLine(label);
//        }
//    }
//}