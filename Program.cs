using System;
using System.Runtime.CompilerServices;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("9 - Sair");

            Console.WriteLine("-----------------------");
            Console.WriteLine("Escolha uma operação: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 9: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear(); //limpa a tela do console

            Console.WriteLine("Insira o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine()); //ReadLine sempre retorna string, Parse é usado para converter para float

            Console.WriteLine("Insira o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(""); //WriteLine usado apenas para pular linha

            float resultado = v1 + v2;

            Console.WriteLine("O resultado da soma é " + resultado);

            // outras maneiras de executar:  
            // Console.WriteLine($"O resultado da soma é {resultado}");
            // Console.WriteLine($"O resultado da soma é {v1 + v2}");
            // Console.WriteLine("O resultado da soma é" + (v1 + v2));

            Console.ReadKey(); // espera uma tecla ser pressionada para finalizar o programa
            Menu(); //chamando a função menu de volta para o usuario no fim de cada operação
        }

        static void Subtracao()
        {
            Console.Clear(); //limpa a tela do console

            Console.WriteLine("Insira o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine()); //ReadLine sempre retorna string, Parse é usado para converter para float

            Console.WriteLine("Insira o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(""); //WriteLine usado apenas para pular linha

            float resultado = v1 - v2;

            Console.WriteLine("O resultado da subtração é " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;

            Console.WriteLine("O resultado da divisão é " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine("O resultado da multiplicação é " + resultado);
            Console.ReadKey();
            Menu();
        }
    }
}