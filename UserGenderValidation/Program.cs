// rakendus küsib sugu
//rakendus küsib perekonna nime
//lähtudest infost tervitab kasutajat
//"Welcome, Mr/Ms (perekonnanimi)"



Console.WriteLine("Please, select your gender (m/f)");

char userGender = Char.Parse(Console.ReadLine());//Loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please, enter your last name:");

string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
} 