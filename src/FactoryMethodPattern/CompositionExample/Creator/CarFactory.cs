﻿namespace FactoryMethodPattern.CompositionExample.Creator
{
    using ConcreteProduct;

    public interface ICarFactoryMethod
    {
        ICar CreateCar();
    }
}