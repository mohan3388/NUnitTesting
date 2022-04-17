using System;
using VendingMachine;

while (true)
{
    Console.WriteLine("\ntype number: \n 1.Binary coversion \n 2.Stopwatch\n 3.Coupen number\n 4.Fewest notes \n 5.Monthly payment\n 6.Temprature Convert\n " +
        "7.Dayofweek \n 8.Sqrtnumber \n");
    Console.WriteLine("Enter any number For excute program");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            BinaryConversion convert = new BinaryConversion();
            convert.Conversion();
            break;
        case 2:
            StopWatch stop = new StopWatch();
            stop.Measure();
            break;
        case 3:
            CoupenNumber coupen = new CoupenNumber();
            coupen.PrintCouponNumber(20);
            break;
        case 4:
            evest vending = new evest();
            vending.MinNumberofnot();
            break;
        case 5:
            MonthlyPayment pay = new MonthlyPayment();
            pay.CalMonthlyPayment(500, 8, 9);
            break;
        case 6:
            TempratureCon conv = new TempratureCon();
            conv.CelTOFer();
            conv.FerToCel();
            break;
        case 7:
            DayofWeek weekof = new DayofWeek();
            weekof.Week();
            weekof.Month();
            break;

        case 8:
            SqrtNewtonMethod.Sqrt();

            break;
        default:
            Console.WriteLine("not found");
            break;

    }
}
