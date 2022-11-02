using System;
class Polinom
{
    private int[] ratio;
    private int size;

    public Polinom()
    {
        size = 1;
        ratio = new int[] {0};
    }

    public Polinom(int volume, int[] ratios)
    {
        size = volume;
        ratio = ratios;
    }

    public void print()
    {
        Console.WriteLine(size);
        for(int i = 0; i < size; i++)
        {
            Console.Write(ratio[i]);
            Console.Write(' ');
        }
    }

    public static Polinom operator +(Polinom a, Polinom b)
    {
        Polinom first;
        Polinom second;
        if (a.size > b.size)
        {
            first = a;
            second = b;
        } else {
            first = b;
            second = a;
        }
        Polinom result = first;
        for(int i = 0; i < second.size; i++)
        {
            result.ratio[i] += second.ratio[i];
        }
        return result;
    }

    public static Polinom operator *(Polinom pol, int num)
    {
        for(int i = 0; i < pol.size; i++)
        {
            pol.ratio[i] *= num;
        }
        return pol;
    }
}

class Progrgam{
    static void Main()
    {
        int[] nums = {1, 2, 3}; 
        Polinom test = new Polinom(3, nums);
        test.print();
        test += new Polinom(10, new int[] {1, 2, 3, 4, 6, 7, 8, 9, 10, 11});
        test.print();
        test *= 10;
        test.print(); 
    }
}