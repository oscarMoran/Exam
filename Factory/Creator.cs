using Factory.Enums;
using Factory.Interfaces;

namespace Factory
{
    public class Creator
    {
        public ICar CreateCar(int opt)
        {
            switch (opt)
            {
                case (int)FactoryValues.Sedan:
                    return new Sedan();
                case (int)FactoryValues.Deportivo:
                    return new Deportivo();
                case (int)FactoryValues.Hatchback:
                    return new Hatchback();
                default:
                    return null;
            }
        }
    }
}