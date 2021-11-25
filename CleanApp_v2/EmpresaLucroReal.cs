using System;
using System.Collections.Generic;
using System.Text;

namespace CleanApp_v2
{
    class EmpresaLucroReal : Empresa
    {
        public EmpresaLucroReal(string razao, int cnpj, double repasseFunc) : base(razao, cnpj, repasseFunc)
        {
        }

        public EmpresaLucroReal(string razao, int cnpj, double repasseFunc, double caixa) : base(razao, cnpj, repasseFunc, caixa)
        {
        }

        public override void avaliarEmpresa()
        {
            base.avaliarEmpresa();
            double nota = 0;

            while (nota < 1 && nota > 10)
            {
                try
                {
                    Console.WriteLine("Digite a nota atribuida para nossa equipe de limpeza!");
                    nota = double.Parse(Console.ReadLine());
                    avaliacoes.Add(nota);
                }
                catch (Exception)
                {
                    nota = 0;
                }
            }
        }

        public override void DistribuirLucros()
        {
            if (caixa > 0)
            {
                double txApp = this.caixa * 0.08;//TX DO APP
                double irFont = this.caixa * 0.2; //IR LUCRO PRESUMIDO ** VALORES FICTÍCIOS **
                this.caixa = caixa - (txApp + irFont);//REDUZ IMPOSTOS + TX DO APP DO CAIXA
                double repFuncIndiv = (this.caixa * repasseFunc) / funcionarios.Count; //VALOR QUE SERÁ RESPASSADO PARA CADA FUNCIONÁRIO

                for (int i = 0; i < funcionarios.Count; i++)
                {
                    funcionarios[i].Saldo += repFuncIndiv;//DISTRUBUINDO LUCRO PARA FUNCIONÁRIOS
                }

                this.caixa = caixa - (repasseFunc * funcionarios.Count);//RETIRA O LUCRO DA EMPRESA

                Console.WriteLine("O lucro líquido da empresa no período foi de: {0}", caixa);

            }
            else
            {
                Console.WriteLine("Você não possui caixa parar realizar a operação!");
            }

        }

        public override void ExecutarLimpeza()
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
