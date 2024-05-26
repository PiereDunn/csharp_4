class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Введите количество строк: ");

        int lines = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Введите количество столбцов: ");

        int pillar = Convert.ToInt32(Console.ReadLine());



        int[,] matrix1 = new int[lines, pillar];

        Random r = new Random();

        int sum1 = 0;

        Console.WriteLine($"\nПервая матрица: \n");

        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < pillar; j++)
            {
                matrix1[i, j] = r.Next(10, 20);

                sum1 += matrix1[i, j];

                Console.Write($"{matrix1[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"\nСумма всех чисел в первой матрице = {sum1} \n");

        Console.ReadKey();



        int[,] matrix2 = new int[lines, pillar];

        Random t = new Random();

        int sum2 = 0;

        Console.WriteLine($"\nВторая матрица: \n");

        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < pillar; j++)
            {
                matrix2[i, j] = t.Next(10, 20);

                sum2 += matrix2[i, j];

                Console.Write($"{matrix2[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"\nСумма всех чисел во второй матрице = {sum2} \n");

        Console.ReadKey();


        Console.WriteLine($"\nСложение двух матриц \n");

        int[,] matrix3 = new int[lines, pillar];

        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < pillar; j++)
            {
                matrix3[i, j] = matrix1[i, j] + matrix2[i, j];

                Console.Write($"{matrix3[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}