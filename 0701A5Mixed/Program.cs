using System;

namespace _0701A5Mixed
{
    class Program
    {
        static float miles(int a)
        {
            return (float)a / 1.609344F;
        }

        static long fak(long a)
        {
            if (a > 1)
                return a * fak(a - 1);
            else
                return 1;
        }


        static int ggt(int a, int b)
        {
            int h;
            if (a == 0) return Math.Abs(b);
            if (b == 0) return Math.Abs(a);

            do
            {
                h = a % b;
                a = b;
                b = h;
            } while (b != 0);

            return Math.Abs(a);
        }

        static int sum(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            char c = ' ', x;
            int a, b;

            while (c != 'E')
            {
                Console.Clear();

                Console.WriteLine("Bitte wählen Sie die gewünschte Funktion ");
                Console.WriteLine("=========================================");
                Console.WriteLine("S -> Summe berechnen                     ");
                Console.WriteLine("F -> Fakultät berechnen                  ");
                Console.WriteLine("G -> Größten gemeinsamen Teiler berechnen");
                Console.WriteLine("M -> Meilen berechnen                    ");
                Console.WriteLine("E -> Programm beenden                    ");

                c = Console.ReadKey().KeyChar;
                c = char.ToUpper(c);
                Console.WriteLine();

                switch (c)
                {
                    case 'S':
                        Console.Write("Bitte Zahl eins eingeben:");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Bitte Zahl zwei eingeben:");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Die Summe der Zahlen ist: {0}", sum(a, b));
                        break;

                    case 'F':
                        Console.Write("Bitte eine Zahl eingeben:");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Die Fakultät von {0} ist: {1}", a, fak(a));
                        break;

                    case 'G':
                        Console.Write("Bitte Zahl eins eingeben:");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Bitte Zahl zwei eingeben:");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Der ggt von {0} und {1} ist: {2}", a, b, ggt(a, b));
                        break;

                    case 'M':
                        Console.Write("Bitte eine Zahl eingeben:");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("{0} km entsprechen {1:F4} Meilen", a, miles(a));
                        break;

                    default:
                        break;
                }

                if (c != 'E')
                {
                    Console.WriteLine();
                    Console.WriteLine("zur Fortsetzung bitte Taste drücken");
                    x = Console.ReadKey().KeyChar;
                }
            }

            Console.WriteLine();

        }
    }
}
