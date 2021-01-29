using Composicao1.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace Composicao1.Entidades {
    class Colaborador {

        public string Nome { get; set; }
        public ColaboradorNivel Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }

        public List<HoraContrato> Contratos { get; set; } = new List<HoraContrato>();

        public Colaborador() {

        }

        public Colaborador(string nome, ColaboradorNivel nivel, double salarioBase, Departamento departamento) {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddContrato (HoraContrato contrato) {
            Contratos.Add(contrato);
        }

        public void RemoveContrato(HoraContrato contrato) {
            Contratos.Remove(contrato);
        }

        public double Ganho(int ano, int mes) {
            double soma = SalarioBase;

            foreach(HoraContrato contrato in Contratos) {
                if(contrato.Data.Year == ano && contrato.Data.Month == mes) {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }
    }
}
