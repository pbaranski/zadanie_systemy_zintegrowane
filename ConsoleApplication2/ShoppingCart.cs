using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ShoppingCart
    {
        protected List<Flower> cartList = new List<Flower>();
        public string owner;
        public string type = "Wózek";

        public void addItem(Flower flower)
        {
            cartList.Add(flower);
        }

        public override string ToString()
        {
            string mess = type + " właściciel " + owner;
            if (cartList.Count == 0) mess= mess + "\n wózek pusty";
            else
            {
                foreach (Flower flower in cartList) mess = mess +"\n"+ flower.print();
            }
            return mess;
        }

        public double allPrice()
        {
            double sum = 0;
            List<Flower> fix = new  List<Flower>();
            fix.AddRange(cartList);
            foreach (Flower flower in cartList)
            {
                if (flower.getPrice() < 0)
                {
                   fix.Remove(flower);                   
                }
                else
                {
                    sum = sum + (flower.getPrice()*flower.getQuantity());
                }              
            }
            cartList=fix;
            return sum;
        }

        public void removeItem()
        {
            Flower i = cartList[0];
            if (i.getQuantity() > 0) i.setQuantity(i.getQuantity() - 1);
            else cartList.Remove(i); 
        }

        public List<Flower> returnCartList()
        {
            return cartList;
        }

        public void clear()
        {
            cartList.Clear();
        }

        public bool empty()
        {
            return cartList.Count < 1;
        }

    }
}
