using Moneys;
namespace Products
{
    public class Product
    {
        private string name;
        private Money price; 

        public Product(string name, Money price)
        {
            this.name = name;
            this.price = price;
        }

        public void EditPrice()
        {
            Console.WriteLine($"\nВведите на сколько рублей хотите уменьшить цену продукта {name} >>");
            int rubles = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"\nВведите на сколько копеек хотите уменьшить цену продукта >>");
            int kopecks = Int32.Parse(Console.ReadLine());

            int newRuble = price._rubles - rubles;
            int newKopecks = price._kopecks - kopecks;

            if (newKopecks < 0)
            {
                newRuble -= 1;
                newKopecks += 100;
            }

            if (newRuble < 0)
            {
                throw new Exception("Цена не может быть отрицательной.");
            }
            else
            {
                price._rubles = newRuble;
                price._kopecks = newKopecks;
            }
        }

        public void PrintProductInfo()
        {
            Console.WriteLine($"Название продукта: {name}");
            Console.Write($"Цена продукта: {price}");
        }
    }
}