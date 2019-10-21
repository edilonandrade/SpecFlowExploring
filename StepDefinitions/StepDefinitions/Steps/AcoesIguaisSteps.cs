using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace StepDefinitions
{
    [Binding]
    public class AcoesIguaisSteps
    {
        private int result = 0;

        [Given(@"que o usuário informe a soma de um número numa váriavel")]
        [Given(@"que o usuário some a um na váriavel novamente")]
        public void DadoQueOUsuarioInformeASomaDeUmNumeroNumaVariavel()
        {
            result += 1;
        }
       
        [When(@"eu verifico a quantidade")]
        public void QuandoEuVerificoAQuantidade()
        {
            //Não há ação
        }
        
        [Then(@"verifico que o valor é igual a (.*)")]
        public void EntaoVerificoQueOValorEIgualA(int expected)
        {
            Assert.AreEqual(expected, result, 0.00001, "O valor não foi o experado.");
        }
    }
}
