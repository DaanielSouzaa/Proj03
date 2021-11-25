using System;
using System.Collections.Generic;
using System.Text;

namespace CleanApp_v2
{
    abstract class Empresa : iLimpar
    {
        private string razaoSocial;
        private int cnpj;
        protected double caixa;
        protected double repasseFunc;

        protected List<Pessoa> funcionarios = new List<Pessoa>();
        protected List<Servico> servicos = new List<Servico>();
        protected List<double> avaliacoes = new List<double>();

        public string RazaoSocial { get => razaoSocial; }
        public int Cnpj { get => cnpj; }
        public double Caixa { get => caixa; }
        public double Repasse { get => repasseFunc; }

        public List<Servico> listServ { get => servicos; }
        public List<Pessoa> listFunc { get => funcionarios; }

        public Empresa(string razao, int cnpj, double repasseFunc, double caixa)
        {
            this.razaoSocial = razao;
            this.cnpj = cnpj;
            this.caixa = caixa;
            this.repasseFunc = repasseFunc/100;
        }

        public void pagar(double valor)
        {
            this.caixa += valor;
        }

        public Empresa(string razao, int cnpj, double repasseFunc)
        {
            this.razaoSocial = razao;
            this.cnpj = cnpj;
            this.repasseFunc = repasseFunc/100;
        }

        public double getAvaliacao()
        {
            double tot = 0;

            for (int i = 0; i < avaliacoes.Count; i++)
            {
                tot += avaliacoes[i];
            }

            return tot / avaliacoes.Count;
        }

        public void addFunc(Pessoa p)
        {
            this.funcionarios.Add(p);
        }

        protected void addFunc()
        {

            try
            {
                Console.WriteLine("Digite o nome do funcionário!");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a idade do funcionário!");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o cpf do funcionário!");
                int cpf = int.Parse(Console.ReadLine());

                funcionarios.Add(new Pessoa(cpf, nome, idade));
            }
            catch (Exception)
            {
                Console.WriteLine("Erro desconhecido ao cadastrar o funcionário!");
            }
        }
        public void addServico(Servico srv)
        {
            this.servicos.Add(srv);
        }
        protected void addServico()
        {
            try
            {
                Console.WriteLine("Digite o nome do serviço que será executado: ");
                string nomeServico = Console.ReadLine();

                Console.WriteLine("Qual a quantidade total horas necessárias para execução do serviço?");
                double horasTotais = double.Parse(Console.ReadLine());

                servicos.Add(new Servico(nomeServico, horasTotais));
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao incluir serviço no escopo!");
            }
        }

        public virtual void avaliarEmpresa()
        {
            double nota = 0;

            while (nota < 1 && nota > 5)
            {
                try
                {
                    Console.WriteLine("Digite a nota atribuida para nossa equipe de limpeza!");
                    nota = double.Parse(Console.ReadLine());
                    avaliacoes.Add(nota);
                } catch(Exception)
                {
                    Console.WriteLine("Teste");
                }
            }
        }

        public abstract void ExecutarLimpeza();
        public abstract void DistribuirLucros();
    }
}
