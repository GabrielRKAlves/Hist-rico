using Exemplos;
using System;
using System.Globalization;

namespace Exemplo1
{
    class Exemplo
    {
        static void Main(string[] args)
        {
       
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();


            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());


            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha é: " + p1.Nome);
            } else Console.WriteLine("Pessoa mais velha é: " + p2.Nome);









            /*string[] valores = Console.ReadLine().Split(' '); 
            int x = int.Parse(valores[0]); 
            int y = int.Parse(valores[1]); 

            while (x != 0 || y != 0){
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }
                valores = Console.ReadLine().Split(' ');
                 x = int.Parse(valores[0]);
                 y = int.Parse(valores[1]);
            }



            /*
            int s = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            int r = s + t;
            Console.WriteLine("Soma: " + r);
            

            /*Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();            
            Console.WriteLine("Quantos quartos tem sua casa: ");
            string quartos = Console.ReadLine();
            Console.WriteLine("Entre com o preco do produto: ");
            string preco = Console.ReadLine();            
            Console.WriteLine("Entre com seu ultimo nome, idade, e altura(mesma linha)");
            string[] s = Console.ReadLine().Split(' ');
            string p1 = s[0];
            string p2 = s[1];
            string p3 = s[2];
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            


            /*double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b,2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta))/2*a;
            double x2 = (-b - Math.Sqrt(delta))/2*a;
            Console.WriteLine(x1);
                Console.WriteLine(x2);
            */

        }
    }
}