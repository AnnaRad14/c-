using System;

namespace lab1
{
    class Product
    {
        private string name;
        private decimal price;
        private int quantity;

        public Product(string name, decimal price, int quantity)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Помилка ");
                return;
            }

            if (price < 0)
            {
                Console.WriteLine("Помилка");
                return;
            }

            if (quantity < 0)
            {
                Console.WriteLine("Помилка");
                return;
            }

            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Помилка");
                    return;
                }

                name = value;
            }
        }
        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Помилка");
                    return;
                }

                price = value;
            }
        }
        public int Quantity => quantity;

        public decimal TotalValue => price * quantity;

        public bool Restock(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Помилка");
                return false;
            }

            quantity += amount;
            return true;
        }
        public bool Sell(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Помилка: Кількість для продажу має бути більше нуля!");
                return false;
            }

            if (amount > quantity)
            {
                Console.WriteLine("Помилка: Недостатньо товару на складі!");
                return false;
            }

            quantity -= amount;
            return true;
        }
        public override string ToString()
        {
            return $"Товар: {name}, Ціна: {price} грн, Кількість: {quantity}, Загальна вартість: {TotalValue} грн";
        }
    }
    class Program
    {
        static void Main()
        {
            Product apple = new Product("Яблуко", 5, 100);
            Console.WriteLine(apple.ToString());

            apple.Sell(20);
            Console.WriteLine(apple.ToString());

            apple.Restock(50);
            Console.WriteLine(apple.ToString());

            apple.Price = 7;
            Console.WriteLine(apple.ToString());

            apple.Name = "Зелене яблуко";
            Console.WriteLine(apple.ToString());

            apple.Price = -10; 
            apple.Name = "";   
            apple.Sell(200);   
        }
    }
}