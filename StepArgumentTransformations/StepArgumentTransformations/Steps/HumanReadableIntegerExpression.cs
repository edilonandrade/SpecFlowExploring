using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepArgumentTransformations.Steps
{
    public class HumanReadableIntegerExpression
    {
        public int Value { get; }
        public HumanReadableIntegerExpression(int value) { Value = value; }
    }
}
