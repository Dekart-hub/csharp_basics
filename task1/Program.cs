using System;
using System.IO;
using System.Text;

namespace FileTask1
{


class Prog
{
    const int POINTS_TO_PASS = 56;
    const string  INPUT_FILE_PATH = @"../input.txt";
    
    static void Task1()
    {
        string[] students = File.ReadAllLines(INPUT_FILE_PATH);
        string[] studentInf;
        for(int i = 0; i < students.Length; i++)
        {
            studentInf = students[i].Split(' ');
            Console.Write($"Студент {studentInf[0]} {studentInf[1]} {studentInf[2]} ");
            if(int.Parse(studentInf[3]) < POINTS_TO_PASS || int.Parse(studentInf[4]) < POINTS_TO_PASS
                         || int.Parse(studentInf[5]) < POINTS_TO_PASS)
            {
                Console.WriteLine("не сдал сессию!");
            } else {
                Console.WriteLine("сдал сессию.");
            }
        } 
    }

    static void task2()
    {
        using(StreamReader fr = new StreamReader(INPUT_FILE_PATH))
        {
            string  line;
            int n;
            while((line = fr.ReadLine()) != null)
            {
                n = int.Parse(line);
                int[,] arr = new int[n, n];
                for(int i = 0; i < n; i++)
                {
                    string col = fr.ReadLine();
                    arr[i] = Array.ConvertAll(col.Split(' '), s =>  int.Parse(s, out var x) ? x : -1);
                }
            }
        }
    }

    static void Main()
    {
        Task1();
    }
    
}
}