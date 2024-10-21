﻿using System;
public class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Grade");
        float? NumGrade = float.Parse(Console.ReadLine());
        string LetterGrade = "null";
        if (100 <= NumGrade)
        {
            LetterGrade = ("A+");
            Console.WriteLine(LetterGrade);
            Console.WriteLine($"Wow! {NumGrade}…That’s impressive! ");
        }

        else if (90 <= NumGrade)
        {
            LetterGrade = ("A");
            Console.WriteLine(LetterGrade);
            Console.WriteLine("Very nice!");
        }

        else if (80 <= NumGrade)
        {
            LetterGrade = ("B");
            Console.WriteLine(LetterGrade);
            Console.WriteLine("Keep it up!");
        }

        else if (70 <= NumGrade)
        {
            LetterGrade = ("C");
            Console.WriteLine(LetterGrade);
            Console.WriteLine("You got this, keep working!");
        }

        else if (60 <= NumGrade)
        {
            LetterGrade = ("D");
            Console.WriteLine(LetterGrade);
            Console.WriteLine("Keep trying! ");
        }

        else {
            LetterGrade = ("D");
            Console.WriteLine(LetterGrade);
            Console.WriteLine("Don’t give up!");
        }
    }
}