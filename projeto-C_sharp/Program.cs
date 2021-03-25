using System;

namespace projeto_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("Hello World!");
            cabecalho("Cabo Verde");
            menu("Santo Antão", "São Vicente", "São Nicolau", "Sal", "Boavista", "Maio", "Santiago", "Brava", "Fogo");
            op = leiaOp(1, 9);
            linha();
            switch (op)
            {
                case 1:
                    Console.WriteLine("Primeiro");
                    break;
                case 2:
                    Console.WriteLine("Primeiro");
                    break;
                case 3:
                    Console.WriteLine("Primeiro");
                    break;
                case 4:
                    Console.WriteLine("Primeiro");
                    break;
                case 5:
                    Console.WriteLine("Primeiro");
                    break;
                case 6:
                    Console.WriteLine("Primeiro");
                    break;
                case 7:
                    Console.WriteLine("Primeiro");
                    break;
                case 8:
                    Console.WriteLine("Primeiro");
                    break;
                case 9:
                    Console.WriteLine("Primeiro");
                    break;
            }
        }
        static void linha()
        {
            Console.WriteLine("------------------------------");
        }
        static void center(string teste, int num)
        {
            int total, esquerda, direita;
            string test = "";
            total = num - teste.Length;
            direita = (total / 2) + teste.Length;
            esquerda = num - direita;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}{1}", teste.PadLeft(direita, ' '), test.PadRight(esquerda-1, ' '));
            Console.ResetColor();
        }
        static void cabecalho(string msg)
        {
            linha();
            center(msg, 30);
            linha();
        }
        static void menu(params string[]lista)
        {
            int c = 1;
            Console.WriteLine("Escolha sua opção: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var item in lista)
            {
                Console.WriteLine($"[{c}] - {item}");
                c++;
            }
            Console.ResetColor();
            linha();
        }
        static int leiaOp(int inf, int sup)
        {
            int op;
            while (true)
            {
                Console.Write("Sua opção: ");
                op = Convert.ToInt32(Console.ReadLine());
                if(op >= inf && op <= sup)
                {
                    return op;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ERRO!!! Digite um número entre {inf} a {sup}");
                Console.ResetColor();
            }
        }

    }
    class CaboVerde
    {
        static int proximo = 1;
        string nome;
        int numero, anoNasc;
    }
    class Barlavento
    {

    }
    class Sotavento
    {

    }
}
