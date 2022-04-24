

namespace ClassesAndObjects
{
    public class Person
    {   
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthDate { get; set; }
        public string Hobby { get; set; }
        public string Gender { get; set; }

        public void Test()
      {
            Console.WriteLine($"Hello my name is:{Name} {Surname} ");
            Console.WriteLine($"I am {DateTime.Now.Year - BirthDate } years old");
        }
     }

}
