//küsib kasutaja sugu (m/f)
//küsib kasutaja perekonnanime
//tervitab kasutajat valitud soo ja perekonnanimega

Console.WriteLine("Please, select your gender (M/F)");
char userGender = Char.Parse(Console.ReadLine()); //kasutaja soo sisend
Console.WriteLine("Please enter your last name"); //kasutaja perekonnanime sisend
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