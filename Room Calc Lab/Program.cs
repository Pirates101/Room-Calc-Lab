namespace Room_Calc_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the room");
            string inputLength = Console.ReadLine();
            double length = double.Parse(inputLength);

            Console.WriteLine("Enter the width of the room");
            string inputWidth = Console.ReadLine();
            double width = double.Parse(inputWidth);

            Console.WriteLine("Enter the height of the room");
            string inputHeight = Console.ReadLine();
            double height = double.Parse(inputHeight);

            double area = width * length;
            double perimeter = (2 * width) + (2 * length);
            double volume = width * length * height;
            double surfaceArea = area * length * width;

            if (area <= 250)
            {
                Console.WriteLine($"The area is {area}, the perimeter is {perimeter}, the surface area is {surfaceArea} and the volume is {volume}. The room is small");
            }
            else if (area >= 250 && area <= 650)
            {
                Console.WriteLine($"The area is {area}, the perimeter is {perimeter}, the surface area is {surfaceArea} and the volume is {volume}. The room is medium");
            }
            else
            {
                Console.WriteLine($"The area is {area}, the perimeter is {perimeter}, the surface area is {surfaceArea} and the volume is {volume}. The room is large");
            }

        }
    }
}