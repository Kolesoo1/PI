namespace PITEST
{
    using System;

    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите коэффициенты квадратного уравнения (ax^2 + bx + c = 0):");

            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            CheckDiscr(a, b, c);
        }

        public static void CheckDiscr(double a, double b, double c)
        {
            // Проверка, что a не равно 0
            if (a == 0)
            {
                Console.WriteLine("Коэффициент a не может быть равен 0.");
                return;
            }

            // Вычисление дискриминанта
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                // Два различных корня
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Корни уравнения: x1 = {x1}, x2 = {x2}");
                CheckVieta(x1, x2, a, b, c);
            }
            else if (discriminant == 0)
            {
                // Один корень
                double x = -b / (2 * a);
                Console.WriteLine($"Корень уравнения: x = {x}");
                CheckVieta(x, x, a, b, c);

            }
            else
            {
                // Нет действительных корней
                Console.WriteLine("Уравнение не имеет действительных корней.");
            }
        }

        public static bool CheckVieta(double x1, double x2, double a, double b, double c)
        {
            double sum = x1 + x2;
            double product = x1 * x2;

            double expectedSum = -b / a;
            double expectedProduct = c / a;

            Console.WriteLine($"Проверка теоремы Виета:");
            Console.WriteLine($"Сумма корней: {sum} (ожидается: {expectedSum})");
            Console.WriteLine($"Произведение корней: {product} (ожидается: {expectedProduct})");

            if (Math.Abs(sum - expectedSum) < 1e-10 && Math.Abs(product - expectedProduct) < 1e-10)
            {
                Console.WriteLine("Теорема Виета выполняется.");
            }
            else
            {
                Console.WriteLine("Теорема Виета не выполняется.");
            }

            return sum == -b / a && product == c/a;
        }


    }
    //Test trigger 2
}