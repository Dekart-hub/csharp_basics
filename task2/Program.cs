

namespace task2
{
class Program
{
    static void Main(string[] args)
    {
        BinaryWriter bw = new BinaryWriter(File.Open("1.bin", FileMode.Create));
        Random r = new Random();
        for(int i=0; i<20; i++)
        {
            bw.Write(r.Next(20));
            Console.Write($"{r} ");
        }
        bw.Close();

        task2();
    }

    static void task1()
    {
        using (BinaryReader br = new BinaryReader(new FileStream("1.bin", FileMode.Open)))
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            long maxPos = br.BaseStream.Position;
            long minPos = br.BaseStream.Position; 
            try
            {
                    
                while (true)
                {
                    int num = br.ReadInt32();
                    if(num > max)
                    {
                        maxPos = br.BaseStream.Position;
                        max = num;
                    } else if (num < min)
                    {
                        minPos = br.BaseStream.Position;
                        min = num;
                    }
                }
            }
            catch(EndOfStreamException e) {
                long left = minPos;
                long right = maxPos;
                if(minPos > maxPos)
                {
                    left = maxPos;
                    right = minPos;
                }
                br.BaseStream.Position = left;
                int sum = 0;
                while(br.BaseStream.Position != right)
                {
                    int num = br.ReadInt32();
                    sum += num;
                } 
                Console.WriteLine($"\n sum={sum}");
            }
        }
    }

    static void task2()
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        long maxPos = 0;
        long minPos = 0;  
        using (BinaryReader br = new BinaryReader(new FileStream("1.bin", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)))
        {
            maxPos = br.BaseStream.Position;
            minPos = br.BaseStream.Position;
            try
            {   
                while (true)
                {
                    int num = br.ReadInt32();
                    if(num > max)
                    {
                        maxPos = br.BaseStream.Position;
                        max = num;
                    } else if (num < min)
                    {
                        minPos = br.BaseStream.Position;
                        min = num;
                    }
                }
            } catch(EndOfStreamException e) {
            }

            try{
                int num = br.ReadInt32();
                Console.Write($"{num} ");                
            } catch(EndOfStreamException e) {
                Console.Write($"\n");
            }
        }
        
    }

}
}