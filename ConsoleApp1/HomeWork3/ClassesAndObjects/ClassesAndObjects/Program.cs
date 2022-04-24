
/* Pirmais mājasdarbs.Lekcija 3.Izveidota jauna klase Phone.cs.Programma izprintē monitorā "Calling" un 
 "SMS sent"*/

using ClassesAndObjects;

Phone telefons = new Phone();
telefons.Size = 20.5;
telefons.Brand = "Nokia";
telefons.Model = "3110";
telefons.Zvana();
telefons.Iszinjas();


/* Otrais mājasdarbs.Lekcija 3.Izveidota jauna klase Car.cs.Mašīna uzsāk braukšanu,paātrinās,signalizē,palēnina
 gaitu un apstājās.Mašīnai ir marka, numurzīme un ātrums.Programma izprintē monitorā uzsākšanu,paātrināšanos,
signālu, palēnināšanos,apstāšanos.*/

Car auto = new Car();
auto.Brand = "Audi";
auto.NumberPlate = "AA100";
auto.Speed = 210;
auto.StartToDrive();
auto.GoFaster();
auto.Beep();
auto.SlowDown();
auto.Stop();


/* Trešais mājasdarbs.Lekcija 3.Izveidota jauna klase Product.cs.Precei ir garums,platums,svars.
 Pēc preces izveidošanas tie nevar tapt mainīti.Programma izprintē visus parametrus.*/

Product prece = new Product();
/*prece.Garums = 10.3;
prece.Platums = 5.5;
prece.Svars = 2.8; */
prece.PrecesParametri();



/* Ceturtais mājasdarbs.Lekcija 3.Izveidota klase Person.cs.Pesonai ir Vārds, Uzvārds, dzimšanas datums,
   hobijs, dzimums.Iegūstam personas visus datus no lietotāja. Izveidojam funkcijas, ka persona māk 
   sasveicināties un zin aprēķināt cik personai ir gadi.
   Pēc personas izveides personas sveiciens un vecums tiek izvadīts konsolē.
 */
Person persona = new Person();
persona.Name = "ABC";
persona.Surname = "DEF";
persona.BirthDate = 1980;
persona.Hobby = "Tennis";
persona.Gender = "Male";
persona.Test();



















