

namespace ClassesAndObjects
{
    public class Product
    {
     
       /* public double Garums { get; set; }
        public double Platums { get; set; }
        public double Svars { get; set; } */

        public double Garums = 10.3;
        public double Platums = 5.5;
        public double Svars = 2.8;

        public void PrecesParametri()
        {
            Console.WriteLine($"Preces garums ir:  {Garums}m");
            Console.WriteLine($"Preces platums ir: {Platums}m");
            Console.WriteLine($"Preces svars ir:   {Svars}kg");
        }

    }
}
