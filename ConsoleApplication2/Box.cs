using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Box : ShoppingCart
    {
        private Customer costumer;
        

        public Box(Customer costumer)
        {
            type="pudełko";
            this.costumer = costumer;
        }

        public void transferCart(ShoppingCart cart)
        {

            this.cartList.AddRange(cart.returnCartList());
            this.owner = cart.owner;
            cart.clear();
        }

        public string valueOf(string color)
        {
            double price = 0;
            foreach (Flower flower in cartList)
            {

                if (flower.getColor().Equals(color))
                {
                    price += (flower.getPrice() * flower.getQuantity());
                    Console.WriteLine("");
                }
            }
            return " " + price;
        }

    }
}
