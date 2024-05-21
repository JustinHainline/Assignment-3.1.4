namespace Assignment_3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());


            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies in the 1st quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies in the 2nd quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies in the 3rd quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies in the 4th quadrant.");
            }
            else if (x == 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies on the Y axis");
            }
            else if (x < 0 && y == 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies on the X axis");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies at the origin.");
            }
        }
    }
}
