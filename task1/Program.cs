using System;
using System.IO;
using System.Text;

namespace FileTask1
{


class Prog
{
    const int POINTS_TO_PASS = 56;
    static void Main()
    {
        string inputFilePath = @"../input.txt";
        string[] students = File.ReadAllLines(inputFilePath);

        string[] studentInf;
        for(int i = 0; i < students.Length; i++)
        {
            studentInf = students[i].Split(' ');
            Console.Write($"Студент {studentInf[0]} {studentInf[1]} {studentInf[2]} ");
            if(int.Parse(studentInf[3]) < POINTS_TO_PASS || int.Parse(studentInf[4]) < POINTS_TO_PASS
                         || int.Parse(studentInf[5]) < POINTS_TO_PASS)
            {
                Console.WriteLine("не закрыл сессию!");
            } else {
                Console.WriteLine("закрыл сессию.");
            }
        } 
    }
}
}