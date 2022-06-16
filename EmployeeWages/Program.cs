Console.WriteLine("Welcome to the Employee Wages Calculator");
Console.WriteLine( "Attendance of the Emplyee based on thier Pesence");

Random random = new Random();

int num =random.Next(0,2);

if (num == 0)
{
    Console.WriteLine("Emp Is Present");

}
else
{
    Console.WriteLine("Emp Is Absent");
}
