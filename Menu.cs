using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEmpresa
{
    public static class Menu
    {
		/// <summary>
		/// Imprime um menu de opções no console para que o usuário escolha uma opção.
		/// </summary>
        
		public static void ImprimirMenu()
        {
            Console.Clear();
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Cadastrar empregado");
            Console.WriteLine("2 - Listar todos empregados cadastrados");
            Console.WriteLine("3 - Promover um empregado");
            Console.WriteLine("4 - Demitir um empregado");
            Console.WriteLine("5 - Listar salário anual dos empregados");
            Console.WriteLine("6 - Sair\n");
        }

		/// <summary>
		/// Lê a opção escolhida pelo usuário e retorna essa opção como uma string.
		/// </summary>
        
		public static string LerOpcao()
        {
            return Console.ReadLine() ?? "2";
        }

		/// <summary>
		/// Solicita informações do usuário para criar um objeto "Empregado".
		/// </summary>
        
		public static Empregado CriarEmpregado()
        {
            string Nome;
            string Sobrenome;
            string Matricula;

            Console.Write("\nDigite o nome do empregado: ");
            Nome = Console.ReadLine() ?? " ";

            Console.Write("\nDigite o sobrenome do empregado: ");
            Sobrenome = Console.ReadLine() ?? " ";

            Console.Write("\nDigite a matricula do empregado: ");
            Matricula = Console.ReadLine() ?? " ";

            Console.Write("\nDigite a idade do empregado: ");
            if(!int.TryParse(Console.ReadLine(), out int Idade))
            {
                Console.WriteLine("Idade inválida.");
                Idade = 0;
            }

            Console.Write("\nDigite a data de nascimento do empregado: ");
            if(!DateTime.TryParse(Console.ReadLine(), out DateTime DataNascimento))
            {
                Console.WriteLine("data de nascimento inválida.");
                DataNascimento = new DateTime(2001,01,01);
            }


            Console.Write("\nDigite a data de contratacão do empregado: ");
            if(!DateTime.TryParse(Console.ReadLine(), out DateTime DataContratacao))
            {
                Console.WriteLine("data de contratacão inválida.");
                DataContratacao = new DateTime(2001,01,01);
            }

            Console.Write("\nDigite o salario mensal do empregado: ");
            if(!double.TryParse(Console.ReadLine(), out double SalarioMensal))
            {
                Console.WriteLine("salario mensal inválido.");
                SalarioMensal = 1320;
            }

            Empregado empregado = new(Nome, Sobrenome, Matricula, Idade, DataNascimento, DataContratacao, SalarioMensal);

            return empregado;
        }

		/// <summary>
		/// Solicita informações do usuário para criar um objeto com informações básicas do empregado.
		/// </summary>

		public static Empregado CriarEmpregadoSimples()
        {
            string Nome;
            string Sobrenome;

            Console.Write("\nDigite o nome do empregado: ");
            Nome = Console.ReadLine() ?? " ";

            Console.Write("\nDigite o sobrenome do empregado: ");
            Sobrenome = Console.ReadLine() ?? " ";

            Console.Write("\nDigite a idade do empregado: ");
            if (!int.TryParse(Console.ReadLine(), out int Idade))
            {
                Console.WriteLine("Idade inválida.");
                Idade = 0;
            }

            Console.Write("\nDigite a data de nascimento do empregado: ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime DataNascimento))
            {
                Console.WriteLine("data de nascimento inválida.");
                DataNascimento = new DateTime(2001, 01, 01);
            }

            Empregado empregado = new(Nome, Sobrenome, Idade, DataNascimento);

            return empregado;
        }

		/// <summary>
		///  Permite ao usuário promover um empregado e chama o método PromoverEmpregado da classe Empresa.
		/// </summary>

		public static void PromoverEmpregado(Empresa empresa)
        {
            Console.Write("Digite o nome do empregado: ");
            string Nome = Console.ReadLine() ?? " ";

            Console.Write("\nDigite o sobrenome do empregado: ");
            string Sobrenome = Console.ReadLine() ?? " ";

            empresa.PromoverEmpregado(Nome, Sobrenome);
        }

		/// <summary>
		/// Permite ao usuário demitir um empregado e chama o método DemitirEmpregado da classe Empresa.
		/// </summary>
        
		public static void DemitirEmpregado(Empresa empresa)
        {
            Console.Write("Digite o nome do empregado: ");
            string Nome = Console.ReadLine() ?? " ";

            Console.Write("\nDigite o sobrenome do empregado: ");
            string Sobrenome = Console.ReadLine() ?? " ";

            empresa.DemitirEmpregado(Nome, Sobrenome);
        }
    }
}
