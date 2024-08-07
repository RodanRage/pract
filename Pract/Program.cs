namespace Pract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short rows = 20;
            short seats = 15;
            short firstSeatNumber = 01643;
            short lastSeatNumber = (short)(firstSeatNumber + rows * seats - 1);
            short inputNumber;
            
            while (!short.TryParse(Console.ReadLine(), out inputNumber) 
                || inputNumber < firstSeatNumber 
                || inputNumber > lastSeatNumber)
            {

            }
            float numberOfSeat = inputNumber - firstSeatNumber + 1;
            int numberOfRow = (int)Math.Round(numberOfSeat / seats, MidpointRounding.ToPositiveInfinity);
            Console.WriteLine($"Номер - {numberOfSeat}, ряд - {numberOfRow}");
            
        }
    }
}
