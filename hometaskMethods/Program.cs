using System.Threading.Channels;

namespace hometaskMethods;

internal class Program
{
    static void Main(string[] args)
    {
        #region Task1

        Console.WriteLine("Iki ededin bolunmesi");
        Console.WriteLine("=====================");
        Console.WriteLine("Boluneni daxil edin");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Boleni ededi daxil edin");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Cavab: {a}/{b}=" + divisor(a, b));

        #endregion

        #region Task2

        int[] numbers = { 444, 25, 6252, 2345, 6547, 3426, 15136 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(i + 1 + " : " + numbers[i]);
        }

        Console.WriteLine("Verilmish arrayin elementlerinin cemi: " + sumOfElements(numbers));
        #endregion

        #region Task3

        Console.WriteLine("Iki eded arasindaki tek ededlerin sayini tapmag ucun ilk ededi daxil edin");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ikinci ededi daxil edin");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{n} ve {m} ededleri araligindaki tek ededlerin sayi: " + numOfOdds(n, m));

        #endregion

        #region Task4


        Console.WriteLine("Ededin sade ve ya murekkeb oldugunu oyrenmek ucun ededi daxil edin:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{a} ededi " + numType(a));

        #endregion

        #region Task5


        Console.WriteLine("Ededin 2-nin quvveti olub-olmamasini oyrenmek ucun ededi daxil edin:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(n + " " + powerOfTwo(n));

        #endregion
    }






    static double divisor(double a, double b)
    {
        return a / b;
    } // 1-ci taskin methodu

    static int sumOfElements(params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    } // 2-ci taskin methodu

    static int numOfOdds(int n, int m)
    {
        int count = 0;
        for(int i = n+1;i < m; i++) 
        {
            if (i % 2 == 1)
            {
                count++;
            }
        }
        return count;
    } // 3-cu taskin methodu

    static string numType(int a)
    {
        for (int i = 2; i < a; i++)
        {
            if (a % i == 0)
                return "murekkebdir";
        }
        return "sadedir";
    } // 4-cu taskin methodu

    static string powerOfTwo(double n)
    {
        while (n>0)
        {
            n = n / 2;
            if (n == 1)
                return "ededi 2-nin quvvetidir";
        }return "ededi 2-nin quvveti deyil";
    } // 5-ci taskin methodu


}
