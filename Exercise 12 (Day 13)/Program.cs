namespace z1
{
    class Program
    {
        public delegate double CalcFigure(double R);
        static double Get_Length(double r)
        {
            double D;
            D = 2 * Math.PI * r;
            Console.WriteLine($"Длина окружности = { D }");
            return D;
        }
        static double Get_Area(double r)
        {
            double S;
            S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Площадь круга = { S }" );
            return S;
        }
        static double Get_Volume(double r)
        {
            double V;
            V = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Объём шара = { V }");
            return V;
        }
        public static void radius (CalcFigure a)
        {
            Console.Write("Введите радиус: ");
            double rd = Convert.ToDouble(Console.ReadLine());
            a(rd);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            CalcFigure CF = new CalcFigure(Get_Length);
            CF += Get_Area;
            CF += Get_Volume;
            
            CF(r);

            Console.WriteLine();

            radius(CF);
            Console.ReadLine();
        }
    }
}