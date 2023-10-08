namespace AtividadeEmpresa
{
	/// <summary>
	/// Classe que representa a empresa e as operações relacionadas aos empregados.
	/// </summary>
    
	public class Empresa
    {
        public string? Nome { get; private set; }
        public string? Cnpj { get; private set; }
        public string? Endereco {  get; private set; }
        public List<Empregado> Empregados { get; private set; }

		///<summary>
		/// Construtor padrão que inicializa a lista de empregados.
		/// </summary>
        
		public Empresa()
        {
            Empregados = new List<Empregado>();
        }

		/// <summary>
		/// Construtor que inicializa uma empresa com nome, CNPJ e endereço.
		/// </summary>
        
		public Empresa(string nome, string cnpj, string endereco)
        {
            Nome = nome;
            Cnpj = cnpj;
            Endereco = endereco;
            Empregados = new List<Empregado>();

        }

		/// <summary>
		/// Construtor que inicializa uma empresa com nome, CNPJ, endereço e uma lista de empregados.
		/// </summary>
        
		public Empresa(string nome, string cnpj, string endereco, List<Empregado> empregados)
        {
            Nome = nome;
            Cnpj = cnpj;
            Endereco = endereco;
            Empregados = empregados;
        }

		/// <summary>
		/// Adiciona um empregado à lista de empregados da empresa.
		/// </summary>

		public void CadastrarEmpregado(Empregado empregado)
        {
            Empregados.Add(empregado);
        }

		/// <summary>
		/// Lista todos os empregados cadastrados na empresa.
		/// </summary>
        
		public void ListarEmpregados()
        {
            foreach(var empregado in Empregados)
            {
                Console.WriteLine(empregado.Nome + " " + empregado.Sobrenome);
            }
        }

		/// <summary>
		/// Promove um empregado, aumentando seu salário.
		/// </summary>

		public void PromoverEmpregado(string Nome, string Sobrenome)
        {
            Empregados.FirstOrDefault(empregado => empregado.Nome == Nome && empregado.Sobrenome == Sobrenome)?.AumentarSalario();
        }

		/// <summary>
		/// Demite um empregado da empresa.
		/// </summary>

		public void DemitirEmpregado(string Nome, string Sobrenome)
        {
            Empregados.RemoveAll(empregado => empregado.Nome == Nome && empregado.Sobrenome == Sobrenome);
        }

		/// <summary>
		/// Lista os salários anuais de todos os empregados da empresa.
		/// </summary>
        
		public void ListarSalariosAnuais()
        {
            Console.WriteLine("Salario anual dos Empregados:");
            foreach (var empregado in Empregados)
            {
                Console.WriteLine(empregado.Nome + " " + empregado.Sobrenome + ": " + Math.Round(empregado.SalarioMensal * 12, 2));
            }
        }
    }
}
