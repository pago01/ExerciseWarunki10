using System;
using System.ComponentModel.Design;

namespace ExerciseWarunki10
{
    //Data structure declaration

    class Program
    {

        private static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            bool parseresult;
            //1st number read
            do
            {
                //a
                Console.WriteLine("Podaj pierwsza liczbę");
                parseresult = Int32.TryParse(Console.ReadLine(), out a);
            }
            while (!parseresult);

            //2nd number read
            do
            {
                //a
                Console.WriteLine("Podaj drugą liczbę");
                parseresult = Int32.TryParse(Console.ReadLine(), out b);
            }
            while (!parseresult);

            //3rd number read
            do
            {
                //a
                Console.WriteLine("Podaj trzecią liczbę");
                parseresult = Int32.TryParse(Console.ReadLine(), out c);
            }
            while (!parseresult);
            //Traingle build check
            if (a+b>c && a+c>b && b+c>a)
            {
                Console.WriteLine("3 odcinki mogą stworzyć trójkąt");
            }
            else
            {
                Console.WriteLine("3 odcinki nie mogą stworzyć trójkąta");
            }
        }
    }
}

