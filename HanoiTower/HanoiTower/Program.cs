using System;

namespace HanoiTower
{
    class Program
    {
        static void Move(int start, int destination, int buffer, int count)
        {
            if (count != 0)
            {
                Move(start, buffer, destination, count - 1);
                Console.WriteLine($"| from {start} to {destination}");
                Move(buffer, destination, start, count - 1);
            }
        }

        static void Main(string[] args)
        {
            Move(1, 3, 2, 4);
        }
    }
}
