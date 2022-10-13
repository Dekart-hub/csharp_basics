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
        string[] content = File.ReadAllLines(INPUT_FILE_PATH);
        int n = 0;
        int count = 0;

        while(n != content.Length)
        {
            count = int.Parse(content[n]);
            for(int i = 0; i < count; i++)
            {
                for(int j = 0; j < count; j++)
                {

                }
            }

        }
        // using(FileStream fr = new FileStream(@"../input.txt", FileMode.Open))
        // {
        //   for(int offset=1; offset <= fr.Length; offset++)
        //         {
        //             fr.Seek(-offset, SeekOrigin.End);
                   
        //             fw.WriteByte((byte)fr.ReadByte());
        //         }
        // }
    }

    static void Main()
    {
        Task1();
    }
    
}
}