using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDespesas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp, despesa;
            double valor, total = 0;

            do
            {
                Console.WriteLine("Informe a despesa");
                despesa = Console.ReadLine();
                Console.WriteLine("Informe o valor");
                valor = double.Parse(Console.ReadLine());

                total = valor;

                Console.WriteLine("Deseja inserir uma nova despesa?");
                resp = Console.ReadLine().ToUpper();
                {
                    while (resp == "S") ;

                    Console.WriteLine("O valor total das despesas é: " + total.ToString("C"));
                    Console.WriteLine("Informe o número de pessoas: ");
                    int pessoas = int.Parse(Console.ReadLine());

                    double media = total / pessoas;

                    Console.WriteLine("O gasto médio por pessoas é: " + media.ToString("C"));

                    Console.ReadKey();
                }
            } while (true);
        }
    }
}
