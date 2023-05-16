// Täienda programmi koodi nii, et programm küsiks kasutajal sisestada tema nime ja tervitaks kasutajat nimepidi:

Console.WriteLine("Enter your name:");
string userName = Console.ReadLine();

GreetUser(userName);
static void GreetUser(string someName)
{
    Console.WriteLine($"Hello, {someName}");
}

// Kirjuta koodi, et kutsuda välja funktsiooni HelloWorld():
HelloWorld();
static void HelloWorld()
{
    Console.WriteLine("Hello, World!");
}

// Täienda kood, et luua lihtsa sammulugeja tulemuse kuvamise rakendus:

Console.WriteLine("How many steps have you walked today?");
int usersSteps = Int32.Parse(Console.ReadLine());

string result = HealthMonitor(usersSteps);
Console.WriteLine(result);
static string HealthMonitor(int steps)
{
    if (steps < 4000)
    {
        return "You need to move more.";
    }
    else if (steps >= 4000 && steps < 8000)
    {
        return "Health goal achieved,";
    }
    else
    {
        return "Well done!";
    }
}