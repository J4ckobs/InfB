using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //C.) sprawdza czy podane napisy są sobie równe nie zależnie od wiellkości liter
        static bool isEqual(string a, string b)
        {
            if (a.ToLower() == b.ToLower()) return true;
            else return false;
        }
        //E
        static int rand(int a)
        {
            Random r = new Random();
            return r.Next(a);
        }
        static string lotto(int amount, int range)
        {
            /*
            string nums = "";
            for (int i = 0; i < amount; i++) nums += " " + rand(range);
            return nums;
            */
            if (amount > 0)
            {
                return " " + rand(range) + lotto(amount-1,range);
            }
            return "";

        }
        //F
        static double poleWalca(int r, int h) //pole walca
        {
            if (h <= 0 || r <= 0)
                return double.NaN;
            else
                return 2 * (Math.PI * Math.Pow(r, 2)) + (2 * Math.PI * r * h); // 2* Pp + Pb = Pc
        }

        static double vWalec(int r, int h) // objetosc walca
        {
            if (h <= 0 || r <= 0)
                return double.NaN;
            else
                return h * Math.PI * Math.Pow(r, 2);
        }
        //H
        static double Solution(double a, double b, double c) // Fukcja zwracająca jedno miejsce zerowe funkcji
        {
            double sDelta = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            if (sDelta < 0)
            {
                return double.NaN;
            }

            return (b + sDelta) / (2 * a);
        }
        //I
        static int sumSeven(int a) //suma liczb podzielnych przez 7
        {
            if (a == 0) return 0;
            else
            {
                if (a % 7 != 0) return sumSeven(a - 1);
                else return a + sumSeven(a - 7);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(isEqual("ptaK", "PTAk")); // B
            Console.WriteLine("Liczby losowanie lotto:" + lotto(5, 50)); // E
            Console.WriteLine("Pole walca: wynosi: " + vWalec(5, 10) + "\nObjetosc walca wynosi: " + poleWalca(5, 10)); // F
            Console.WriteLine("Jedno z miejsc zerowych f-cji: " + Solution(2, 6, 1)); // H
            Console.WriteLine("Suma liczb podzielnych przez 7 dla zakresu (1 - 40): " + sumSeven(40)); //I
        }
    }
}
