namespace z3
{
    class Program
    {
        delegate string WorkerString(string str);
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();


            WorkerString ws = ToUpper;
            ws += Trim;
            ws += ToLower;

            Console.WriteLine($"\r\nИзмененная строка: {ws(str)}");


            static string ToUpper(string str) => str.ToUpper();
            static string ToLower(string str) => str.ToLower();
            static string Trim(string str) => str.Trim();

        }
    }
}