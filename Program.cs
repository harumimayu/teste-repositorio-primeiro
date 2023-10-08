namespace AtividadeEmpresa
{
	/// <summary>
	/// Classe principal que gerencia empregados da empresa.
	/// </summary>
    
	class Program
    {
        public static void Main()
        {
            Empresa empresa = new("Carrefour", "45543915016690", "Av. Contorno 1341, Floresta");
            string opcao = "";

            while (opcao != "6")
            {
                Menu.ImprimirMenu(); // Exibe o menu de opções para o usuário.


				opcao = Menu.LerOpcao(); // Lê a opção escolhida pelo usuário.

				// Executa de acordo com  à opção escolhida pelo usuário.

				switch (opcao) 
                {
                    case "1":

						// Permite ao usuário cadastrar um novo empregado na empresa.
						empresa.CadastrarEmpregado(Menu.CriarEmpregado());

                        break;
                    case "2":

						// Lista todos os empregados cadastrados na empresa.
						empresa.ListarEmpregados();

                        break;
                    case "3":

						// Permite ao usuário promover um empregado.
						Menu.PromoverEmpregado(empresa);

                        break;
                    case "4":

						// Permite ao usuário demitir um empregado.
						Menu.DemitirEmpregado(empresa);

                        break;
                    case "5":

						// Lista o salário anual de todos os empregados.
						empresa.ListarSalariosAnuais();

                        break;

                    default:
                        Console.WriteLine($"Opção inválida."); // Mensagem de erro para opções inválidas.
						break;
                }

                Console.ReadLine();
            }
        }
    }
}