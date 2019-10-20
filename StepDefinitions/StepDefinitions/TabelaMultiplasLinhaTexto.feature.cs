// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace StepDefinitions
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Teste de especificação com tabela", Description="\tComo Estudante do SpecFlow\r\n\tEu quero fazer um teste com tabela\r\n\tDe modo que eu" +
        " possa entender como os dados de tabela se comportam", SourceFile="TabelaMultiplasLinhaTexto.feature", SourceLine=2)]
    public partial class TesteDeEspecificacaoComTabelaFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TabelaMultiplasLinhaTexto.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Teste de especificação com tabela", "\tComo Estudante do SpecFlow\r\n\tEu quero fazer um teste com tabela\r\n\tDe modo que eu" +
                    " possa entender como os dados de tabela se comportam", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Utilização de tabela com sucesso", SourceLine=7)]
        public virtual void UtilizacaoDeTabelaComSucesso()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Utilização de tabela com sucesso", null, ((string[])(null)));
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Autor",
                        "Titulo"});
            table1.AddRow(new string[] {
                        "Martin Fowler",
                        "Analysis Patterns"});
            table1.AddRow(new string[] {
                        "Gojko Adzic",
                        "Briding the Communication Gap"});
#line 9
 testRunner.Given("os livros abaixo", ((string)(null)), table1, "Dado ");
#line 13
 testRunner.When("eu faço a tranferencia dos livro para uma outra variavel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Autor",
                        "Titulo"});
            table2.AddRow(new string[] {
                        "Martin Fowler",
                        "Analysis Patterns"});
            table2.AddRow(new string[] {
                        "Gojko Adzic",
                        "Briding the Communication Gap"});
#line 14
 testRunner.Then("verifico que os dados estão iguais aos abaixo", ((string)(null)), table2, "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion