﻿using System.Globalization;

namespace ExercicoFixação.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct() 
        {
        }

        public ImportedProduct(string name, double price, double customFee)
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {

            return Name
               + " $ "
               + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
               + " (Customs fee: $ "
               + CustomFee.ToString("F2", CultureInfo.InvariantCulture)
               + ")";
        }
    }
}
