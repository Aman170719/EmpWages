Console.WriteLine("Welcome to the Employee Wages Calculator");
Console.WriteLine("Attendance of the Emplyee based on thier Pesence");
//constant values
int Emp_daily_wages = 20;
int Emp_work_hrs = 0;

//Random genertor for Attendacne

Random random = new Random();
int num = random.Next(0, 3);
//if (num == 0)
//  Console.WriteLine("Emp Is Present");

switch (num)
{
    case 0:
        Console.WriteLine("Empolye Present Full Time");
        Emp_work_hrs = 8;
        break;
    case 1:
        Console.WriteLine("Empolyee Present Part Time");
        Emp_work_hrs = 4;
        break;
    case 2:
        Console.WriteLine("Absent");
        Emp_work_hrs = 0;
        break;
}
int Emp_wage = (Emp_work_hrs * Emp_daily_wages);
Console.WriteLine("Employee Wages is " + Emp_wage);
Console.WriteLine("Emp Monthly Sal " + (Emp_wage * 20));
