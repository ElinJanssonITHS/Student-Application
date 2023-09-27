using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Common.Enums;
namespace Calculator.Common.Classes;


public record Operation
{
    public double Value { get; private set; }
    public Operators Operator { get; private set; } = default;
    public char OperatorValue => (char)Operator;

    public Operation(double value, Operators @operator) => (Value, Operator) = (value, @operator);

    public Operation SetOperator(Operators @operator) 
    {
        Operator = @operator;
        return this;
    }
    public Operation SetValue(double value)
    {
        Value = value;
        return this;
    }
}
