namespace Topic_5___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string compass;
            double degree;

            Console.Write("Please enter a bearing between 0 and 360 degrees:");
            while (!Double.TryParse(Console.ReadLine(), out degree) || degree < 0 ||  degree > 360)
            {
                Console.Write("That is an invalid input... Try Again:");
            }
            Console.WriteLine();
            if (degree >= 315 || degree <= 45)
            {
                compass = "North";
            }
            else if (degree >= 270 && degree <= 225)
            {
                compass = "West";
            }
            else if (degree <= 135 && degree >= 45)
            {
                compass = "East";
            }
            else
            {
                compass = "South";
            }
            Console.WriteLine();
            Console.WriteLine($"The compass is pointing {compass}");


        }
    }
}
