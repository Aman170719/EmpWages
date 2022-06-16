Console.WriteLine("Welcome to the Employee Wages Calculator");
Console.WriteLine("Attendance of the Emplyee based on thier Pesence");
//constant values
const int Emp_daily_wages = 20;
const int Emp_work_hrs= 8;
const int Emp_work_hrs_P_T = 4;


// Random genertor for Attendacne
Random random = new Random();
int num = random.Next(0, 2);
if (num == 0)
{
    Console.WriteLine("Emp Is Present");
    Console.WriteLine("Employe Daily salary is" + Emp_daily_wages * Emp_work_hrs);
    Console.WriteLine("Employe Monthly Salary is" + (Emp_daily_wages * Emp_work_hrs) * 20);
    Console.WriteLine("Employee Woking Partime Salary is :" + (Emp_work_hrs_P_T * Emp_daily_wages) * 20);

}
else
{
    Console.WriteLine("Emp Is Absent");
}