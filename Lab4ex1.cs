using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4ex1
{
    class lmao
    {
        int code;
        string mename;
        string maname;
        int price;
        int quantityon;
        int quantitysold;
        DateTime manu;
        DateTime exp;
        int number;
        int plannedsales;
        int actualsales;
        string region;
        public lmao(int code, string mename, string maname, int price, int quantityon, int number)
        {
            this.code = code;
            this.mename = mename;
            this.maname = maname;
            this.price = price;
            this.quantityon = quantityon;
            this.number = number;
        }
        public void Display()
        {
            Console.WriteLine(code);
            Console.WriteLine(mename);
            Console.WriteLine(maname);
            Console.WriteLine(price);
            Console.WriteLine(quantityon);
            Console.WriteLine(manu);
            Console.WriteLine(exp);
            Console.WriteLine(number);
        }
    }
    class Lab4ex1
    {
        static void Main(string[] args)
        {
            lmao objmedicine = new lmao(1234, "dAl", "lol", 69, 22, 6969);
            objmedicine.Display();
            Console.ReadLine();
        }
    }
}
