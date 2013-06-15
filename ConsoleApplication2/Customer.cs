using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Customer
    {
        private string name;
        private double ownMoney;
        private ShoppingCart cart = new ShoppingCart();

        public Customer(string name, double ownMoney)
        {
            this.name = name;
            this.ownMoney = ownMoney;
            cart.owner = name;
        }

        public void get(Flower flower)
        {
            cart.addItem(flower);
        }

        public string  getShoppingCart()
        {
            return cart.ToString();
        }

        public ShoppingCart getCart()
        {
            return cart;
        }


        public void pay()
        {            
            if(!cart.empty())
            if (ownMoney >= cart.allPrice())ownMoney = ownMoney- cart.allPrice();
            else
            {
                Console.WriteLine("Brak siana - coś zabierzemy");
                cart.removeItem();
                pay();
            }
            else Console.WriteLine("Nic w koszu");
        }
       
        public double getCash()
        {
            return ownMoney;
        }


        public void pack(Box box) {
            box.transferCart(cart);
            
        }
    }
}
