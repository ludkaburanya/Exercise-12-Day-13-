namespace z2
{
    public delegate double MyDelegat(double x, double y);
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите арифметическое действие:");
            string x = Console.ReadLine();
            Console.WriteLine("Введите первое число:");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double b = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case "+":
                    MyDelegat myDelegat = (z, r) => z + r;
                    double del = myDelegat(a, b);
                    Console.WriteLine("Ответ: {0}", del);
                    break;
                case "-":
                    MyDelegat myDelegat1 = (z, r) => z - r;
                    double del1 = myDelegat1(a, b);
                    Console.WriteLine("Ответ: {0}", del1);
                    break;
                case "*":
                    MyDelegat myDelegat2 = (z, r) => z * r;
                    double del2 = myDelegat2(a, b);
                    Console.WriteLine("Ответ: {0}", del2);
                    break;
                case "/":
                    MyDelegat myDelegat3 = (z, r) => { return z == 0 ? 0 : z / r; };
                    double del3 = myDelegat3(a, b);
                    Console.WriteLine("Ответ: {0}", del3);
                    break;
            }
            Console.ReadKey();

        }
    }
}