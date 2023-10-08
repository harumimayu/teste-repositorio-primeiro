/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeEmpresa;

namespace backup
{
    internal class Backup
    {
        public static void Mainx()
        {
            Empresa empresa = new("Carrefour", "45543915016690", "Av. Contorno 1341, Floresta");

            Empregado empregado1 = new("Anderson", "Gomes", "366724", 22, new DateTime(2000, 11, 15), new DateTime(2022, 05, 05), 1836);
            Empregado empregado2 = new("Anna", "Rabelo", "38878", 22, new DateTime(2000, 10, 09), new DateTime(2019, 04, 05), 2450);
            Empregado empregado3 = new("João", "Silva", "12345", 30, new DateTime(1990, 5, 15), new DateTime(2015, 8, 10), 500.0);
            Empregado empregado4 = new("Maria", "Santos", "54321", 28, new DateTime(1995, 3, 20), new DateTime(2018, 4, 5), 5000.0);
            Empregado empregado5 = new("Carlos", "Pereira", "98765", 35, new DateTime(1986, 11, 7), new DateTime(2010, 6, 25), 4200.0);

            empresa.CadastrarEmpregado(empregado1);
            empresa.CadastrarEmpregado(empregado2);
            empresa.CadastrarEmpregado(empregado3);
            empresa.CadastrarEmpregado(empregado4);
            empresa.CadastrarEmpregado(empregado5);

            empresa.ListarEmpregados();

            Console.WriteLine();

            foreach (var emp in empresa.Empregados)
            {
                Console.WriteLine($"Salario do(a) {emp.Nome}: {emp.SalarioMensal}");
            }

            Console.WriteLine();

            Console.WriteLine($"Salario do {empregado3.Nome} {empregado3.Sobrenome}: {empregado3.SalarioMensal}");

            empresa.PromoverEmpregado("João", "Silva");

            Console.WriteLine($"Novo Salario do {empregado3.Nome} {empregado3.Sobrenome}: {empregado3.SalarioMensal}");

            Console.WriteLine();

            empresa.DemitirEmpregado("Maria", "Santos");

            empresa.ListarEmpregados();

            empresa.ListarSalariosAnuais();

        }
    }
}
*/