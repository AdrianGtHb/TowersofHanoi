using System;

namespace TowerofHanoi
{
    class Program
    {
        static void hanoi(int n, int start, int end)
        {
            if(n == 1)
            {
                Console.WriteLine("From " + start + " to " + end);
            }
            else
            {
                int other = 6 - (start + end);
                hanoi(n - 1, start, other);
                Console.WriteLine("From " + start + " to " + end);
                hanoi(n - 1, other, end);
            }
        }
        static void Main(string[] args)
        {
            hanoi(3, 1, 3);
        }
    }
}
