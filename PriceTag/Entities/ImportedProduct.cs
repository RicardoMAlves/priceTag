﻿using System.Globalization;

namespace PriceTag.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            double p = Price + CustomsFee;
            return p;
        }

        public override string PriceTag()
        {
            return Name + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs Fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
