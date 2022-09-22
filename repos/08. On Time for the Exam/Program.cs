using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            //calculaitons
            int examTimeCalculation = examHour * 60 + examMinute;
            int arrivalTimeCalculation = arrivalHour * 60 + arrivalMinute;
            string status = "";

            if (arrivalTimeCalculation >= examTimeCalculation-30 && arrivalTimeCalculation <= examTimeCalculation)
            {
                status = "On time";
            }
            else if (arrivalTimeCalculation < examTimeCalculation - 30)
            {
                status = "Early";
            } else if (arrivalTimeCalculation > examTimeCalculation)
            {
                status = "Late";
            }

            //print
            if (status == "On time" && arrivalTimeCalculation == examTimeCalculation)
            {
                Console.WriteLine(status);
            }
            else if (status == "Late")
            {
                Console.WriteLine(status);
                if (arrivalTimeCalculation - examTimeCalculation < 60)
                {
                    Console.WriteLine($"{arrivalTimeCalculation - examTimeCalculation} minutes after the start");
                }
                else
                {
                    string finalMinutesCalculation = "";
                        if ((arrivalTimeCalculation - examTimeCalculation)%60 < 10)
                    {
                        finalMinutesCalculation = "0" + (arrivalTimeCalculation - examTimeCalculation) % 60;
                    }
                    else
                    {
                        finalMinutesCalculation = Convert.ToString((arrivalTimeCalculation - examTimeCalculation) % 60);
                    }
                    Console.WriteLine($"{(arrivalTimeCalculation - examTimeCalculation)/60}:{finalMinutesCalculation} hours after the start");
                }
            }
            else if (status == "Early" || status == "On time")
            {
                Console.WriteLine(status);
                if (examTimeCalculation - arrivalTimeCalculation < 60)
                {
                    Console.WriteLine($"{examTimeCalculation - arrivalTimeCalculation} minutes before the start");
                }
                else
                {
                    string finalMinutesCalculation = "";
                    if ((examTimeCalculation - arrivalTimeCalculation) % 60 < 10)
                    {
                        finalMinutesCalculation = "0" + (examTimeCalculation - arrivalTimeCalculation) % 60;
                    }
                    else
                    {
                        finalMinutesCalculation = Convert.ToString((examTimeCalculation - arrivalTimeCalculation) % 60);
                    }
                    Console.WriteLine($"{(examTimeCalculation - arrivalTimeCalculation) / 60}:{finalMinutesCalculation} hours before the start");
                }
            }
        }
    }
}
