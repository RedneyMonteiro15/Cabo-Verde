using System;

namespace projeto_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            menu("Lista", "sjdk", "njisj", "jdjdk");
            leiaOp(1, 4);
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
            linha();
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
                Console.WriteLine($"ERR!!! Digite um número entre {inf} a {sup}");
                Console.ResetColor();
            }
        }

    }
    class CaboVerde
    {
        
    }
    class SantoAntao : CaboVerde
    {

    }
    class SaoVicente : CaboVerde
    {

    }
    class SaoNicolau : CaboVerde
    {

    }
    class Sal : CaboVerde
    {

    }
    class Boavista : CaboVerde
    {

    }
    class Maio : CaboVerde
    {

    }
    class Santiago : CaboVerde
    {

    }
    class Brava : CaboVerde
    {

    }
    class Fogo : CaboVerde
    {

    }
}
