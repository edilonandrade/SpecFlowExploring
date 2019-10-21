using System.Diagnostics;
using TechTalk.SpecFlow;

namespace StepDefinitions
{
    [Binding]
    public class ChamandoPassosDeDefinicaoPassoSteps : Steps
    {
        [Given(@"que o usuário ""(.*)"" existe")]
        public void DadoQueOUsuarioExiste(string name)
        {
            Debug.Print($"1 - que o usuário {name}\n");
        }
        
        [Given(@"o usuário está logado como ""(.*)""")]
        public void DadoOUsuarioEstaLogadoComo(string name)
        {
            Debug.Print($"2 - o usuário está logado como {name}\n");
        }
        
        [Given(@"""(.*)"" está logado")]
        public void DadoEstaLogado(string name)
        {
            Debug.Print("Chamando do passo 3\n");
            Given(string.Format(@"que o usuário ""{0}"" existe", name));
            Given(string.Format(@"o usuário está logado como ""{0}""", name));
        }

        [Given(@"um relatório de despeas para jan (.*) com os dados:")]
        public void DadoUmRelatorioDeDespeasParaJanComOsDados(int ano, Table table)
        {
            Debug.Print("Exibido o relatório com os dados de despesas\n");
        }

        [Given(@"um simples relatório de despesa como")]
        public void DadoUmSimplesRelatorioDeDespesaComo()
        {
            string[] header = { "account", "description", "amount" };
            string[] row1 = { "INT-100", "Taxi", "114" };
            string[] row2 = { "CUC-101", "Peeler", "22" };
            var t = new Table(header);
            t.AddRow(row1);
            t.AddRow(row2);
            Given("um relatório de despeas para jan 2019 com os dados:", t);
        }

    }
}
