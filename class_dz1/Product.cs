using System;

namespace leson_02_dz_02_
{
    public class Product
    {
        private string _name_product = string.Empty;
        private Money money;
        public Product(string name_product, int integer, int fractional)
        {
            _name_product = name_product;
            money = new Money(integer, fractional);
        }
        public void ShowProduct()
        {
            Console.WriteLine($"Продукт  : {_name_product}");
            Console.WriteLine($"Цена     : {money._total_amount} грн");
        }
        public void ReducePriceMinus(int integer, int fractional)
        {
            money.MinusMoney(integer, fractional);
            if (money._total_amount < 0)
            {
                throw new ArgumentException("Цена продукта ниже 0");
            }
        }
        public void IncreasePricePlus(int integer, int fractional)
        {
            money.PlusMoney(integer, fractional);
        }

    }
}
