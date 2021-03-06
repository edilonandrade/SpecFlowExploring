﻿using TechTalk.SpecFlow;

namespace StepArgumentTransformations.Steps
{
    [Binding]
    public class MyStepArgumentTransformations
    {
        //This is possible by specifying a regular expression for the transformation
        [StepArgumentTransformation(@"(\d+|no)")]        
        public int TransformItemsInStockExpressionToInteger(string expression)
        {
            if (expression == "no")
                return 0;

            return int.Parse(expression);
        }

        [StepArgumentTransformation]
        public HumanReadableIntegerExpression TransformHumanReadableIntegerExpression(string expression)
        {
            if (expression == "no")
                return new HumanReadableIntegerExpression(0);

            return new HumanReadableIntegerExpression(int.Parse(expression));
        }
    }
}
