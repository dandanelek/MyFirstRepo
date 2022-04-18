// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Pirmais uzdevums (sasveicināšanās konsoles aplikācija) -----------");
Console.WriteLine("Kāds ir Jūsu vārds?");
   string userInput = Console.ReadLine();
Console.WriteLine("Sveicināti, " + userInput);
Console.WriteLine("----------------------");
Console.WriteLine("--- Otrais uzdevums (Iegūst lietotāja vecumu un izvada lietotājam cik gadi viņam paliks nākamgad (int.Parse)) ---");
Console.WriteLine("Kāds ir Jūsu vecums ?");
   int userNumber = int.Parse(Console.ReadLine());
   int addedToUserNumber = userNumber + 1;
Console.WriteLine("Nākamgad Jums paliks " + addedToUserNumber);
Console.WriteLine("----------------------");
Console.WriteLine("--- Trešais uzdevums (Iegūst no lietotāja skaitļus un atrādīs lietotājam lielāko skaitli (Math.Max)) ---");
Console.WriteLine("Lūdzu, ievadiet pirmo skaitli");
   int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadiet otro skaitli");
   int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadiet trešo skaitli");
   int thirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadiet ceturto skaitli");
   int fourthNumber = int.Parse(Console.ReadLine());
   int firstMaxNumber = Math.Max(firstNumber, secondNumber);
   int secondMaxNumber = Math.Max(thirdNumber, fourthNumber);
   int maxNumber = Math.Max(firstMaxNumber, secondMaxNumber);
Console.WriteLine("Lielākais skaitlis ir:   " + maxNumber);
Console.WriteLine("----------------------");
Console.WriteLine("--- Ceturtais uzdevums (Iegūst no lietotāja skaitļus un atrādīs lietotājam mazāko skaitli (Math.Min)) ---");
Console.WriteLine("Lūdzu, ievadiet pirmo skaitli");
   int firstNumberTwo = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadiet otro skaitli");
   int secondNumberTwo = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadiet trešo skaitli");
   int thirdNumberTwo = int.Parse(Console.ReadLine());
   int firstMinNumber = Math.Min(firstNumberTwo, secondNumberTwo);
   int secondMinNumber = Math.Min(firstMinNumber, thirdNumberTwo);
   int minNumber = Math.Min(firstMinNumber, secondMinNumber);
Console.WriteLine("Mazākais skaitlis ir:   " + minNumber);
Console.WriteLine("----------------------");
Console.WriteLine("--- Piektais uzdevums (Iegūst no lietotāja skaitļus un atrādīs dalījuma atlikumu (%)) ---");
Console.WriteLine("Lūdzu, ievadiet pirmo skaitli");
   int firstNumberThree = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadiet otro skaitli");
   int secondNumberThree = int.Parse(Console.ReadLine());
   int result = firstNumberThree % secondNumberThree;
Console.WriteLine("Dalījuma atlikums ir:   " + result);
Console.WriteLine("----------------------");
Console.WriteLine("--- Sestais uzdevums (Iegūst no lietotāja skaitli un parāda vai lietotājs ievadījis pāra vai nepāra skaitli (Odd or Even)) ---");
Console.WriteLine("Lūdzu, ievadi skaitli");
   int number = int.Parse(Console.ReadLine());
   bool isEven = number % 2 == 0;
Console.WriteLine("Skaitlis ir pāra skaitlis:   " + isEven);
Console.WriteLine("----------------------");
Console.WriteLine("--- Septītais uzdevums (Taisnstūra laukuma aprēķināšana) ---");
Console.WriteLine("Iegūst no lietotāja taisnstūra malu vērtības un aprēķina taisnstūra laukumu.");
Console.WriteLine("Lūdzu, ievadiet pirmo skaitli");
   int firstNumberFour = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadiet otro skaitli");
   int secondNumberFour = int.Parse(Console.ReadLine());
   int area = firstNumberFour * secondNumberFour;
Console.WriteLine("Taisnstūra laukums ir:   " + area);
Console.WriteLine("----------------------");
Console.WriteLine("--- Astotais uzdevums (Taisnleņķa trijstūra laukuma aprēķināšana) ---");
Console.WriteLine("Iegūst no lietotāja skaitli, lai aprēķinātu taisnleņķa vienādsānu trijstūra laukumu ");
Console.WriteLine("Lūdzu, ievadiet trijstūra malas garumu");
   int numberTwo = int.Parse(Console.ReadLine());
   int areaTwo = numberTwo * numberTwo / 2;
Console.WriteLine("Taisnleņķa vienādsānu trijstūra laukums ir:   " + areaTwo);
Console.WriteLine("----------------------");
Console.WriteLine("--- Devītais uzdevums (Interpolācija) ---");
Console.WriteLine("Iegūst lietotāja vārdu,vecumu un izvada lietotājam vārdu un vecumu izmantojot interpolāciju");
Console.WriteLine("Lūdzu ievadiet savu vārdu");
   string userName = Console.ReadLine();
Console.WriteLine("Lūdzu ievadiet savu vecumu");
   int userAge = int.Parse(Console.ReadLine());
Console.WriteLine($"Sveiks {userName}, jūsu vecums ir {userAge}.");
Console.WriteLine("----------------------");





























