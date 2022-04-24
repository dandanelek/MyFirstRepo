

namespace ClassesAndObjects
{
    public class Car

    {
        public string Brand { get; set; }
        public string NumberPlate { get; set; }
        public double Speed { get; set; }

        public void StartToDrive()
        {
            Speed = 10;
            Console.WriteLine("Sākam braukšanu");
        }

        public double GoFaster()
        {
            Speed += 10;
            Console.WriteLine($"Ātrums ir: {Speed}km/h");
            return Speed;
        }

        public void Beep()
        {
            Console.WriteLine("BEEP,BEEP,BEEP");
        }

        public double SlowDown()
        {
            Speed -= 10;
            Console.WriteLine($"Ātrums ir: {Speed}km/h");
            return Speed;
        }

        public void Stop()
        {
            Speed = 0;
            Console.WriteLine("Apstāšanās");
        }
    }

}
