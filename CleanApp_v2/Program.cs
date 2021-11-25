using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanApp_v2
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        //[STAThread]
        public static List<Empresa> empresas = new List<Empresa>();//ESTRUTURAS UTILIZADAS NO PROGRAMA
        public static List<Servico> servicos = new List<Servico>();
        public static List<string> etapas = new List<string>();
        public static List<double> valorEtapas = new List<double>();
        public static List<Pessoa> pessoas = new List<Pessoa>();//ESTRUTURAS UTILIZADAS NO PROGRAMA

        public static string nome;
        public static bool sessao = true;//ESTRUTURAS UTILIZADAS NO PROGRAMA

        static void Main()//FUNCAO PRINCIPAL
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new nome());
            nome formName = new nome();//INSTANCIAS DAS TELAS
            formName.ShowDialog(); 
            Tipo formTipo = new Tipo();
            visaoEmpresa ve = new visaoEmpresa();//INSTANCIAS DAS TELAS

            nome = formName.name;//FORM NOME
            while (sessao)//MANTER PROGRAMA EXECUTANDO
            {
                formTipo.ShowDialog();
                string tipo = formTipo.tipo;

                if (tipo == "Cliente")
                {
                    if(empresas.Count > 0)
                    {
                        listaEmpresas();
                    } else
                    {
                        MessageBox.Show("Não existem empresas cadastradas no sistema!");
                        tipo = "";
                    }
                } else
                {

                    if (empresas.Count == 0)
                    {
                        cadEmpresa();
                    }

                    ve.ShowDialog();
                }
            }
            
        }

        public static void cadServicos()//TELA DE CADASTRO DE SERVICO
        {
            addServico cs = new addServico();
            cs.ShowDialog();
        }

        public static void cadEmpresa()//TELA DE CADASTRO DE EMPRESA
        {
            formCadEmpresa ce = new formCadEmpresa();
            ce.ShowDialog();
        }

        public static void cadPessoas()//TELA DE CADASTRO DE PESSOAS
        {
            telaCadFunc tc = new telaCadFunc();
            tc.ShowDialog();
        }

        public static void listaEmpresas()//TELA DE LISTAGEM DAS EMPRESAS
        {
            telalistaEmpresas le = new telalistaEmpresas();
            le.ShowDialog();
        }
        public static void telaEmpresa(string empresa)//TELA DE VISAO DA EMPRESA
        {
            telaMenuEmpresa tm = new telaMenuEmpresa(empresa);
            tm.ShowDialog();
        }

        public static void showServicos(Empresa p)//ALTERADO
        {

        }

        public static void Form_closeForm(object sender, FormClosedEventArgs e)//FECHA PROGRAMA
        {
            Environment.Exit(0);
            MessageBox.Show("Fechado com sucesso!");
        }

        public static void generateDados()//GERA DADOS RANDOMICOS
        {
            empresas.Clear();
            etapas.Clear();
            servicos.Clear();
            valorEtapas.Clear();
            pessoas.Clear();

            EmpresaLucroPresumido elp = new EmpresaLucroPresumido("EmpLP1",123,50,5000);
            EmpresaLucroPresumido elp2 = new EmpresaLucroPresumido("EmpLP2", 12, 52,1000);
            EmpresaLucroPresumido elp3 = new EmpresaLucroPresumido("EmpLP3", 10, 57,100000);

            EmpresaLucroReal elr = new EmpresaLucroReal("EmpLR1", 1234, 65,852);
            EmpresaLucroReal elr2 = new EmpresaLucroReal("EmpLR2", 12345, 69);
            EmpresaLucroReal elr3 = new EmpresaLucroReal("EmpLR3", 12346, 70,69870);

            elp.addFunc(new Pessoa(1, "a", 1));
            elp2.addFunc(new Pessoa(2, "b", 2));
            elp3.addFunc(new Pessoa(3, "c", 3));

            elp.addFunc(new Pessoa(4, "d", 4));
            elp2.addFunc(new Pessoa(5, "e", 5));
            elp3.addFunc(new Pessoa(6, "f", 6));

            elp.addFunc(new Pessoa(7, "g", 7));
            elp2.addFunc(new Pessoa(8, "h", 8));
            elp3.addFunc(new Pessoa(9, "i", 9));

            elr.addFunc(new Pessoa(1, "a", 1));
            elr2.addFunc(new Pessoa(2, "b", 2));
            elr3.addFunc(new Pessoa(3, "c", 3));

            elr.addFunc(new Pessoa(4, "d", 4));
            elr2.addFunc(new Pessoa(5, "e", 5));
            elr3.addFunc(new Pessoa(6, "f", 6));

            elr.addFunc(new Pessoa(7, "g", 7));
            elr2.addFunc(new Pessoa(8, "h", 8));
            elr3.addFunc(new Pessoa(9, "i", 9));

            Servico srv1 = new Servico("a", 1);
            Servico srv2 = new Servico("b", 2);
            Servico srv3 = new Servico("c", 3);
            Servico srv4 = new Servico("d", 4);
            Servico srv5 = new Servico("e", 5);
            Servico srv6 = new Servico("f", 6);
            Servico srv7 = new Servico("g", 7);
            Servico srv8 = new Servico("h", 8);
            Servico srv9 = new Servico("i", 9);
            Servico srv10 = new Servico("j", 10);

            srv1.cadLimpeza("a", 50);
            srv1.cadLimpeza("b", 30);
            srv1.cadLimpeza("c", 258);

            srv2.cadLimpeza("d", 501);
            srv2.cadLimpeza("e", 320);
            srv2.cadLimpeza("f", 258);

            srv3.cadLimpeza("g", 521);
            srv3.cadLimpeza("h", 330);
            srv3.cadLimpeza("i", 248);

            srv4.cadLimpeza("j", 511);
            srv4.cadLimpeza("k", 3230);
            srv4.cadLimpeza("l", 23128);

            srv5.cadLimpeza("m", 511);
            srv5.cadLimpeza("n", 3250);
            srv5.cadLimpeza("o", 2584);

            srv6.cadLimpeza("p", 50141);
            srv6.cadLimpeza("q", 3201);
            srv6.cadLimpeza("r", 2585);

            srv7.cadLimpeza("s", 5071);
            srv7.cadLimpeza("t", 3208);
            srv7.cadLimpeza("u", 2588);

            srv8.cadLimpeza("v", 5019);
            srv8.cadLimpeza("w", 3201);
            srv8.cadLimpeza("x", 25821);

            srv9.cadLimpeza("y", 51);
            srv9.cadLimpeza("z", 3220);
            srv9.cadLimpeza("aa", 2528);

            srv10.cadLimpeza("ab", 50187);
            srv10.cadLimpeza("ac", 32076);
            srv10.cadLimpeza("ad", 25648);

            srv1.calcularPrecoTotal();
            srv2.calcularPrecoTotal();
            srv3.calcularPrecoTotal();
            srv4.calcularPrecoTotal();
            srv5.calcularPrecoTotal();
            srv6.calcularPrecoTotal();
            srv7.calcularPrecoTotal();
            srv8.calcularPrecoTotal();
            srv9.calcularPrecoTotal();
            srv10.calcularPrecoTotal();

            elp.addServico(srv1);
            elp2.addServico(srv2);
            elp3.addServico(srv3);
            elp.addServico(srv4);
            elp2.addServico(srv5);
            elr.addServico(srv6);
            elr2.addServico(srv7);
            elr2.addServico(srv8);
            elr3.addServico(srv9);
            elr3.addServico(srv10);

            empresas.Add(elp);
            empresas.Add(elp2);
            empresas.Add(elp3);

            empresas.Add(elr);
            empresas.Add(elr2);
            empresas.Add(elr3);

            MessageBox.Show("Dados criados com sucesso!");
        }
    }
}
