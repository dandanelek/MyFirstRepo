

namespace ClassesAndObjects
{
    public class Phone
    {

        public double Size {get;set;}
        public string Brand {get;set;}
        public string Model {get;set;}

    
      public void Zvana()
      {
        Console.WriteLine("Calling");
      }

      public void Iszinjas()
      {
        Console.WriteLine("SMS sent");
      }
    }

}
