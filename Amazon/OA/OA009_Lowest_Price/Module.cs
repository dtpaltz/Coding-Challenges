namespace Amazon.OA009_Lowest_Price
{
    internal class Module
    {
        private Dictionary<string, Discount> dCollection;

        private void DefineDiscounts(string[][] discounts)
        {
            dCollection = new Dictionary<string, Discount>();

            for (int i = 0; i < discounts.Length; i++)
            {
                string tag = discounts[i][0];
                int dType = int.Parse(discounts[i][1]);
                int dAmount = int.Parse(discounts[i][2]);

                dCollection.Add(tag, new Discount(dType, dAmount));
            }
        }

        public int LowestPrice(string[][] products, string[][] discounts)
        {
            DefineDiscounts(discounts);
            int result = 0;

            for (int i = 0; i < products.Length; i++)
            {
                int pPrice = int.Parse(products[i][0]);
                var pDisTags = products[i].Skip(1).Where(t => !string.IsNullOrEmpty(t) && t != "EMPTY").ToArray();
                var prodPrices = new HashSet<int>();

                if (pDisTags.Length == 0)
                {
                    prodPrices.Add(pPrice);
                }
                else
                {
                    foreach (var dTag in pDisTags)
                    {
                        var thisPrice = CalcDiscount(pPrice, dTag);
                        prodPrices.Add((int)thisPrice);
                    }
                }

                result += prodPrices.Min();
            }

            return result;
        }

        private double CalcDiscount(int price, string discountTag)
        {
            Discount dis;
            if (dCollection.ContainsKey(discountTag))
            {
                dis = dCollection[discountTag];
            }
            else
            {
                throw new KeyNotFoundException("Discount tag key not found: " + discountTag);
            }

            double result = dis.Calculate(price);
            return Math.Round(result);
        }

        private class Discount
        {
            public int Type { get; set; }

            public int Amount { get; set; }

            public Discount(int type, int amount)
            {
                Type = type;
                Amount = amount;

                if (Type < 0 || Type > 2)
                {
                    throw new InvalidDataException("Invalid discount type: " + Type);
                }
            }

            public double Calculate(int price)
            {
                double result = 0;

                switch (Type)
                {
                    case 0:
                        result = Amount;
                        break;
                    case 1:
                        double pOff = Amount / 100.0;
                        result = price - (price * pOff);
                        break;
                    case 2:
                        result = price - Amount;
                        break;
                }

                if (result < 0)
                {
                    throw new Exception("Negative discount does not make sense!!!!!");
                }

                return result;
            }
        }
    }
}
