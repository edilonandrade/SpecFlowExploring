using TechTalk.SpecFlow;

namespace StepArgumentTransformations.Steps
{
    [Binding]
    public class MyStepArgumentTransformations
    {
        [StepArgumentTransformation]
        public int TransformItemsInStockExpressionToInteger(string expression)
        {
            if (expression == "no")
                return 0;

            return int.Parse(expression);
        }
    }
}
