using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Rose : Flower
    {
          public Rose(int quantity)
        {
            initFlower("róża", "czerwony", quantity);
        }
    }
}
