
namespace homework8.models
{
    internal class Product
    {
        public string BrandName;
        public string Model;
        public int Price;
        public int Cost;
        public int Income;
        public int Count;

        public Product(string brandName, string model, int price,int cost,int count)
        {
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            if (count > 0)
            {
                Count = count;
            }
            else
            {
                count = 0;
            }
            
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Brand Name:{BrandName}, Model:{Model}, Price:{Price}, Cost:{Cost}, Count:{Count}, Income:{Income}");
        }

        public void Sale(int soldcount)
        {
            if (soldcount <= Count)
            {
                Count -= soldcount;
                Income += soldcount * Price - Cost;
            }
            else
            {
                Console.WriteLine("you don't have that much products");
            }
        }

        public int Refill(int count)
        {
            Count += count;
            return Count;
        }

    }
}
