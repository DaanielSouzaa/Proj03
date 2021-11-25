using System;
using System.Collections.Generic;
using System.Text;

namespace CleanApp_v2
{
    class EmpresaLucroPresumido : Empresa
    {
        //APLICACAO DA HERANCA
        public EmpresaLucroPresumido(string razao, int cnpj, double repasseFunc) : base(razao, cnpj, repasseFunc)
        {
        }

        public EmpresaLucroPresumido(string razao, int cnpj, double repasseFunc, double caixa) : base(razao, cnpj, repasseFunc, caixa)
        {
        }
        //CONTRUTORES

        public override void DistribuirLucros()//FUNCAO DISTRIBUICAO DE LUCRO DA INTERFACE
        {
            if (caixa > 0)
            {
                double txApp = this.caixa * 0.1;//TX DO APP
                double irFont = this.caixa * 0.15; //IR LUCRO PRESUMIDO ** VALORES FICTÍCIOS **
                this.caixa = caixa - (txApp + irFont);
                double repFuncIndiv = (this.caixa * repasseFunc) / funcionarios.Count; //VALOR QUE SERÁ RESPASSADO PARA CADA FUNCIONÁRIO

                for (int i = 0; i < funcionarios.Count; i++)
                {
                    funcionarios[i].Saldo += repFuncIndiv;
                }
                Console.WriteLine("O lucro líquido da empresa no período foi de: {0}", caixa);
                this.caixa = caixa - (repFuncIndiv * funcionarios.Count);
            }
            else
            {
                Console.WriteLine("Você não possui caixa parar realizar a operação!");
            }

        }

        public override void ExecutarLimpeza()//FUNCAO DA INTERFACE LIMPEZA
        {
            if (servicos.Count > 0)
            {
                Console.WriteLine("Escolha um dos nossos serviços:");
                for (int i = 0; i < servicos.Count; i++)
                {
                    Console.WriteLine("{4} | Nome:{0} | Duração: {1} | Valor: {2}", servicos[i].NomeLimpeza, servicos[i].HorasExecucao, servicos[i].ValorTotal, i + 1);
                }
                try
                {
                    int idx = int.Parse(Console.ReadLine());
                    this.caixa += servicos[idx].ValorTotal;
                    for (int i = 0; i < servicos[idx].etapas.Count; i++)
                    {
                        Console.WriteLine("Etapa: {0} | {1}%", servicos[idx].etapas[i], (i / servicos[idx].etapas.Count) * 100);
                    }
                    Console.WriteLine("Limpeza executada com sucesso!");

                    avaliarEmpresa();
                }
                catch (Exception)
                {
                    Console.WriteLine("Não foi possível executar a tarefa!");
                }
            }
        }
    }
}
