using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace Bindings.Steps
{
    [Binding, Scope(Tag = "mytag")]  //Aqui ele identifica apenas os cenários que tem essa tag
    [Scope(Scenario = "Teste de scope sem tag")] //Aqui os cenárioa que tem o título
    [Scope (Feature = "ScopedBindingsExample")] //Asssim todos os steps são identificados, esse ordem de scope estão com a lógica OR
    public class ScopedBindingsExampleSteps
    {
        [Given(@"Que eu tenha uma tag"), Scope(Tag ="controller")]
        public void GivenQueEuTenhaUmaTag()
        {
            Debug.Print("Que eu tenha uma tag \n");
        }
        
        [When(@"eu faço uma ação relacionada a esse tag")]
        public void WhenEuFacoUmaAcaoRelacionadaAEsseTag()
        {
            Debug.Print("eu faço uma ação relacionada a esse tag \n");
        }
        
        [Then(@"vejo que ela foi executada")]
        public void ThenVejoQueElaFoiExecutada()
        {
            Debug.Print("vejo que ela foi executada \n");
        }

        [Given(@"Que eu tenha um cenário sem tag")]
        public void GivenQueEuTenhaUmCenarioSemTag()
        {
            Debug.Print("Que eu tenha um cenário sem tag \n");
        }

        [When(@"eu faço uma ação no cenário sem tag")]
        public void WhenEuFacoUmaAcaoNoCenarioSemTag()
        {
            Debug.Print("eu faço uma ação no cenário sem tag \n");
        }

        [Then(@"vejo que a ação não foi executada")]
        public void ThenVejoQueAAcaoNaoFoiExecutada()
        {
            Debug.Print("vejo que a ação não foi executada \n");
        }

    }
}
