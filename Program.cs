using System;
public class RecursiveFunction
{
    public static int reverse(int num,int rev)
    {
        if (num == 0)
            return rev;
        else
            return reverse(num / 10, (rev * 10) + (num % 10));
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter a number:");
        int n, r;
        n = Convert.ToInt32(Console.ReadLine());
        r = reverse(n,0);
        Console.WriteLine("The reversed number is " + r);
    }
}