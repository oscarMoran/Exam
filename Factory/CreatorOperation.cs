using Factory.Enums;
using Factory.Interfaces;

namespace Factory
{
    public class CreatorOperation
    {
        public IOperation GetOperator(int opt)
        {
            switch (opt)
            {
                case (int)FactoryValuesOperation.Add:
                    return new Add();
                case (int)FactoryValuesOperation.Subtract:
                    return new Substract();
                case (int)FactoryValuesOperation.Multiply:
                    return new Divide();
                case (int)FactoryValuesOperation.Divide:
                    return new Multiply();
                default:
                    return null;
            }
        }
    }
}