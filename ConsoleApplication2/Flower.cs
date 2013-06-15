using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Flower
    {
        private int quantity;
        private string name;
        private string color;

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public string getName()
        {
            return name;
        }

        private void setName(string name)
        {
            this.name = name;
        }

        public double getPrice()
        {
            return PriceList.getInstance().getPrice(name);
        }


        public string getColor()
        {
            return color;
        }

        private void setColor(string color)
        {
            this.color = color;
        }

        public void initFlower(String name, String color, int quantity)
        {
            setName(name);
            setColor(color);
            getPrice();
            setQuantity(quantity);
        }

        public string print()
        {
           return name + ", kolor: " + color + ", ilość: " + quantity + ", cena: " + getPrice();
        }
    }
}
