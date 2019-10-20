using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace StepDefinitions
{
    [Binding]
    public class TesteDeEspecificacaoComTabelaSteps
    {
        IEnumerable<Livro> livros;
        IEnumerable<Livro> livrosResultado;

        [Given(@"os livros abaixo")]
        public void DadoOsLivrosAbaixo(Table table)
        {          
           livros = table.CreateSet<Livro>(); 
        }
        
        [When(@"eu faço a tranferencia dos livro para uma outra variavel")]
        public void QuandoEuFacoATranferenciaDosLivroParaUmaOutraVariavel()
        {
            livrosResultado = livros;
        }

        [Then(@"verifico que os dados estão iguais aos abaixo")]
        public void EntaoVerificoQueOsDadosEstaoIguaisAosAbaixo(Table table)
        {
            table.CompareToSet<Livro>(livrosResultado);
        }
    }

}
