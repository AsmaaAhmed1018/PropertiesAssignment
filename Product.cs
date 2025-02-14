using System.Security.Cryptography;

namespace PropertiesAssignment
{
    internal class Product
    {
        public string Name { get; set; }
        private int price;
        public int Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }
        private int stockQuantity;
        public int StockQuantity
        {
            get { return stockQuantity; }
            private set
            {
                if (value > 0)
                {
                    stockQuantity = value;
                }
            }
        }
        private bool isAvailable;
        public bool IsAvailable
        {
            get
            {
                return isAvailable;
            }
            set
            {
                if (stockQuantity > 0)
                {
                    isAvailable = true;
                }
            }
        }
        public int UpdateStore(int count)
        {
            if (count >0)
            {
                stockQuantity += count;
            }
            return stockQuantity;
        }
    }
}
