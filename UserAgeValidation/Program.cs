//küsib kasutaja vanust
//kui kasutaja vanus on 13 siis on kasutaja liiga noor instagrammi jaoks
//üle 13 aastasele kuvab tere tulemast instagrammi

Console.WriteLine("Enter your age:");
string userAge = Console.ReadLine(); //kasutaja vanuse sisend
int userAgeNum = 0;
bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);
if (isAgeNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram!");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}