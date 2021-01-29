using System;
using System.Globalization;
using Composicao1.Entidades;
using Composicao1.Entidades.Enums;


namespace Composicao1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre com o nome do Departamento: ");
            string deptNome = Console.ReadLine();
            Console.WriteLine("Entre com os dados do Colaborador: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nivel (Junior/Pleno/Senior): ");
            ColaboradorNivel nivel = Enum.Parse<ColaboradorNivel>(Console.ReadLine());
            Console.Write("Salario base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento dept = new Departamento(deptNome);
            Colaborador colaborador = new Colaborador(nome, nivel, salarioBase, dept);

            Console.Write("Quantos contratos para esse colaborador? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <=n; i++) {
                Console.WriteLine($"Entre com o #{i} dado do contrato:");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duracao (horas): ");
                int horas = int.Parse(Console.ReadLine());

                HoraContrato contrato = new HoraContrato(data, valorPorHora, horas);
                colaborador.AddContrato(contrato);
            }

            Console.WriteLine();
            Console.Write("Entre com o mes e o ano para calcular o ganho (MM/YYYY): ");
            string mesEAno = Console.ReadLine();
            int mes = int.Parse(mesEAno.Substring(0, 2));
            int ano = int.Parse(mesEAno.Substring(3));

            Console.WriteLine("Nome: " + colaborador.Nome);
            Console.WriteLine("Departamento: " + colaborador.Departamento.Nome);
            Console.WriteLine("Ganho por " + mesEAno + ": " + colaborador.Ganho(ano, mes).ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
