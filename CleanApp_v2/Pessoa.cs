using System;
using System.Collections.Generic;
using System.Text;

namespace CleanApp_v2
{
    class Pessoa
    {
        private int cpf;
        private string nome;
        private int idade;
        private double saldo;

        public int Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; }
        public int Idade { get => idade; set => idade = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public Pessoa(int cpf, string nome, int idade)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.idade = idade;
        }
    }
}
