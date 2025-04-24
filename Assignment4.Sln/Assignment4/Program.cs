namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bicycle> myBicycles = new List<Bicycle>();
            myBicycles.Add(new Bicycle("Giant", "2024", colourEnum.Black, 0, 75));
            myBicycles.Add(new Bicycle("Trek", "2025", colourEnum.Silver, 0, 70));
            myBicycles.Add(new Bicycle("Canyon", "2023", colourEnum.White, 0, 70));


            myBicycles[0].pedalFaster(20);
            myBicycles[1].pedalFaster(30);
            myBicycles[2].pedalFaster(50);

            foreach (Bicycle bicycle in myBicycles)
            {
                Console.WriteLine($"The {bicycle.getModel()} is travelling at {bicycle.getSpeed()} km/hour");
            }

            while (true)
            {
                foreach (Bicycle bicycle in myBicycles)
                {
                    Console.WriteLine($"The {bicycle.getModel()} is travelling at {bicycle.getSpeed()}km/hour, " +
                        $"Mileage is {Math.Round(bicycle.getDistance(), 2)}");

                }
                Console.WriteLine("");
                Thread.Sleep(5000);
            }  
        }
    }
}
