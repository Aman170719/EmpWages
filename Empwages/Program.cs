Console.WriteLine("Welcome to the Employee Wages Calculator");
Console.WriteLine("Attendance of the Emplyee based on thier Pesence");
//constant values

int MAXDAY = 20;
int MAXHRS = 100;
int RATEPERHRS = 30;
int Emp_work_hrs = 0;
int max_hr = 0;
int max_day = 0;

while(max_hr <= MAXHRS && max_day <= MAXDAY)
{
    max_day++;
    //Random genertor for Attendacne
    Random random = new Random();
    int num = random.Next(0, 2);

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
}





//if (num == 0)
//Console.WriteLine("Emp Is Present");


int Emp_wage = (Emp_work_hrs * RATEPERHRS);
Console.WriteLine("Employee Daily Wages is " + Emp_wage);
Console.WriteLine("Emp Monthly Sal " + (Emp_wage * 20));
