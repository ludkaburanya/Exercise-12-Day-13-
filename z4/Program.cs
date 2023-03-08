namespace z4
{
    class Program
    {
        delegate int MyDelegat();
        delegate double MyDeleg (MyDelegat[] x);
        private static int GetRandom()
        {
            Random random = new Random();
            int number = random.Next(0,20);
            Console.WriteLine(number);
            return number;
        }
        static void Main()
        {
            Console.WriteLine("Введите число элементов массива: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 50));

            var array = new MyDelegat[m];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new MyDelegat(GetRandom)();
            }
            MyDeleg average = delegate (MyDelegat[] x)
            {
                double sr = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    sr += x[i]();
                }
                return sr / array.Length;
            };
            Console.WriteLine("\nСреднее арифметическое = {0}", average(array));
            Console.WriteLine(new string('-', 50));
        }
    }
}