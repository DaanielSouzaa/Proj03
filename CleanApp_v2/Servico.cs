using System;
using System.Collections.Generic;
using System.Text;

namespace CleanApp_v2
{
    class Servico
    {//CLASSE DE SERVICOS
        private double horasExecucao;
        private string nomeLimpeza;
        private double valorTotal;

        public List<string> etapas = new List<string>();//LISTAS UTILIZADAS PARA GUARDAR ETAPAS E VALORES DOS SERVICOS
        private List<double> valorEtapas = new List<double>();

        public double HorasExecucao { get => horasExecucao; }//GETTERS
        public string NomeLimpeza { get => nomeLimpeza; }
        public double ValorTotal { get => valorTotal; }//GETTERS

        public Servico(string nomeLimpeza, double horasExecucao)//CONSTRUTOR
        {
            this.nomeLimpeza = nomeLimpeza;
            this.horasExecucao = horasExecucao;
        }

        public void cadLimpeza(string nome,double valor)//CADASTRO DE LIMPEZA 1
        {
            this.etapas.Add(nome);
            this.valorEtapas.Add(valor);
        }

        public void cadLimpeza()//CADASTRO DE LIMPEZA VIA CONSOLE
        {
            bool valid = true;

            while (valid)
            {
                Console.WriteLine("Digite o nome da etapa que será executada:");
                string etapa = Console.ReadLine();
                try
                {
                    Console.WriteLine("Digite o valor da etapa {0}:", etapa);
                    double valor = Double.Parse(Console.ReadLine());

                    etapas.Add(etapa);
                    valorEtapas.Add(valor);
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro ao cadastrar tarefa!");
                }

                Console.WriteLine("Gostaria de cadastrar uma tarefa? digite N para sair ou qualquer outra tecla para sim");
                if (Console.ReadLine() == "c")
                {
                    valid = false;
                }
            }
            this.calcularPrecoTotal();
        }

        public void calcularPrecoTotal()//FECHA O PRECO TOTAL DO SERVICO DE ACORDO COM AS ETAPAS CADASTRADAS
        {
            for (int i = 0; i < valorEtapas.Count; i++)
            {
                this.valorTotal += valorEtapas[i];
            }
        }
    }
}
