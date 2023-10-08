namespace AtividadeEmpresa
{
	/// <summary>
	/// Classe que representa um empregado da empresa com as principais informações.
	/// </summary>
    
	public class Empregado
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string? Matricula { get; private set; }
        public int Idade { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public DateTime DataContratacao { get; private set; }

        private double salarioMensal;

		/// <summary>
		/// Salário mensal do empregado, com validação para garantir que o valor não seja inferior a 1320.
		/// </summary>
        
		public double SalarioMensal
        {
            get
            {
                return salarioMensal;
            }
            set
            {
                if(value < 1320)
                {
                    salarioMensal = 1320;
                    return;
                }
                salarioMensal = value;
            }
        }

		/// <summary>
		/// Construtor para criar um empregado com informações básicas.
		/// </summary>
        
		public Empregado(string Nome, string Sobrenome, int Idade, DateTime DataNascimento)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Idade = Idade;
            this.DataNascimento = DataNascimento;
        }

		/// <summary>
		/// Construtor para criar um empregado com informações completas.
		/// </summary>
        
		public Empregado(string Nome, string Sobrenome, string Matricula, int Idade, DateTime DataNascimento, DateTime DataContratacao, double SalarioMensal)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Matricula = Matricula;
            this.Idade = Idade;
            this.DataNascimento = DataNascimento;
            this.DataContratacao = DataContratacao;
            this.SalarioMensal = SalarioMensal;
        }

		/// <summary>
		/// Aumenta o salário do empregado em 10%.
		/// </summary>
        
		public void AumentarSalario()
        {
            SalarioMensal += SalarioMensal * 10 / 100;
        }


    }
}
