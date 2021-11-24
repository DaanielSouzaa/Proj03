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
        public static List<Empresa> empresas = new List<Empresa>();
        public static List<Servico> servicos = new List<Servico>();
        public static List<string> etapas = new List<string>();
        public static List<double> valorEtapas = new List<double>();
        public static List<Pessoa> pessoas = new List<Pessoa>();

        public static string nome;
        public static bool sessao = true;

        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new nome());
            nome formName = new nome();
            formName.ShowDialog(); 
            Tipo formTipo = new Tipo();
            visaoEmpresa ve = new visaoEmpresa();
            
            nome = formName.name;
            while (sessao)
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
                        MessageBox.Show("N�o existem empresas cadastradas no sistema!");
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

        public static void cadServicos()
        {
            addServico cs = new addServico();
            cs.ShowDialog();
        }

        public static void cadEmpresa()
        {
            formCadEmpresa ce = new formCadEmpresa();
            ce.ShowDialog();
        }

        public static void cadPessoas()
        {
            telaCadFunc tc = new telaCadFunc();
            tc.ShowDialog();
        }

        public static void listaEmpresas()
        {
            listaEmpresas le = new listaEmpresas();
            le.ShowDialog();
        }
        public static void telaEmpresa(string empresa)
        {
            telaMenuEmpresa tm = new telaMenuEmpresa(empresa);
            tm.ShowDialog();
        }
    }
}
