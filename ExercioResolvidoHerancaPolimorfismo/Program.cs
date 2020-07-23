using System;
using System.Collections.Generic;
using ExercioResolvidoHerancaPolimorfismo.Entidades;
using System.Globalization;

namespace ExercioResolvidoHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> empregados = new List<Empregado>();

            Console.Write("Informe o número de funcionário: ");
            int numeroFuncionario = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroFuncionario; i++)
            {
                Console.WriteLine($"Dados do empregado #{i}: ");
                Console.Write("Empregado Terceirizado (y/n)? ");
                char simOuNao = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (simOuNao == 'y')
                {
                    Console.Write("Despesa adicional: ");
                    double despesaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    empregados.Add(new EmpregadoTerceirizado(nome, horas, valorPorHora, despesaAdicional));
                }
                else
                {
                    empregados.Add(new Empregado(nome, horas, valorPorHora));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");
            foreach (Empregado empregado in empregados)
            {
                Console.WriteLine(empregado.Nome + " - $ " + empregado.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }

          

        }
    }
}
