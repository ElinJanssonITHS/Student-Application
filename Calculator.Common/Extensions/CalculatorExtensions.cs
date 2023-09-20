using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Common.Records;
using Calculator.Common.Enums;
using System.Collections;

namespace Calculator.Common.Extensions;

public static class CalculatorExtensions
{
    public static Operation ChangeOperator (this Operation result, Operators @operator) =>  result.SetOperator(@operator);
    public static Operation ChangeValue(this Operation result, double value) => result.SetValue(value);
    public static Operation Calculate(this Operation result, Operation operation) => result.Operator switch
    {
        Operators.Add => result.ChangeValue(result.Value + operation.Value),
        Operators.Subtract => result.ChangeValue(result.Value - operation.Value),
        Operators.Multiply => result.ChangeValue(result.Value * operation.Value),
        Operators.Divide => result.ChangeValue(result.Value / operation.Value),
        Operators.Equals => result,
        _ => throw new ArgumentException("Opertion does not exist.", nameof(operation))
    };
}
