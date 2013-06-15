using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class PriceList
    {
         public Dictionary<string, double> prices = new Dictionary<string,double>() {{"róża", 8.9}, {"frezja", -1}, {"piwonia", 4.3}, {"lilia", 8.7}};
        
       private PriceList()
       {         
       }

        private static PriceList priceList = new PriceList();

        public static PriceList getInstance()
        {
            return priceList;
        }
        
        public double getPrice(String name)
        {
            double price;
            try
            {
                prices.TryGetValue(name, out price);
                return price;
            }
            catch (ArgumentNullException e) 
            {
                return -1;   
            }
        }
    }
}
