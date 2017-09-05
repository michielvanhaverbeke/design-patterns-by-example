﻿namespace AbstractFactoryPattern.SecondExample.Client
{
    using AbstractProduct;
    using Products;

    public class ItalianLasagnaStore : ILasagnaStore
    {
        public void OrderLasagna(string lasagnaType)
        {
            var lasagna = new TomatoLasagna();
            lasagna.Prepare();
            lasagna.Serve();
        }
    }
}