using System;

namespace kalkulatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("--------------------------");
                Console.WriteLine("Program Kalkulator Console");
                Console.WriteLine("--------------------------");

                Console.Write("Masukkan angka pertama: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan angka kedua  : ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Operasi Masukan : ");
                Console.WriteLine("\t+ : Tambah");
                Console.WriteLine("\t- : Kurang");
                Console.WriteLine("\t* : Kali");
                Console.WriteLine("\t/ : Bagi");
                Console.Write("Operasi Masukan: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Hasil: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Hasil: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Hasil: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Hasil: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("maaf ini tidak valid");
                        break;
                }
                Console.Write("Apakah anda ingin melanjutkan ? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Terimakasih !");
            Console.ReadKey();
        }
    }
}
