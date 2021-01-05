using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4ex2
{
    class product
    {
        private int productid;
        private string productname;
        private float price;
        private int stock;
        public product(int id, string name, float price, int stock)
        {
            productid = id;
            productname = name;
            this.price = price;
            this.stock = stock;
        }
        public void Display()
        {
            Console.WriteLine(productid);
            Console.WriteLine(productname);
            Console.WriteLine(price);
            Console.WriteLine(stock);
        }
        static void Main(string[] args)
        {
            product objstudent = new product(111, "YEet", 420, 69);
            objstudent.Display();
            Console.ReadKey();
        }
    }
}
