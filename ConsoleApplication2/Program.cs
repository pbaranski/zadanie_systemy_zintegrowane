using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {


            // Kwiaciarnia samoobsługowa
    Florist kwiaciarnia = new Florist();

    // Przychodzi klient janek. Ma 200 zł
    Console.WriteLine("JANEK I 200ZŁ");
    Customer janek = new Customer("Janek", 200);

    // Bierze różne kwiaty: 5 róż, 5 piwonii, 3 frezje, 3 bzy
    janek.get(new Rose(5));
    janek.get(new Peony(5));
    janek.get(new Freesia(3));
    janek.get(new Lilac(3));

    // Pewnie je umieścił na wózku sklepowyem
    // Zobaczmy co tam ma
    ShoppingCart wozekJanka = janek.getCart();
    Console.WriteLine("Przed płaceniem\n" + wozekJanka);

    // Teraz za to zapłaci...
    janek.pay();

    // Czy przypadkiem przy płaceniu nie okazało się,
    // że w wozku są kwiaty na które nie ustalono jescze cceny?
    // W takim razie zostałyby usunięte z wózka i Janek nie płaciłby za nie

    Console.WriteLine("Po zapłaceniu\n" + janek.getShoppingCart());

    // Ile Jankowi zostało pieniędzy?
    Console.WriteLine("Jankowi zostało : " + janek.getCash() + " zł");

    // Teraz jakos zapakuje kwiaty (może do pudełka)
    Box pudelkoJanka = new Box(janek);
    janek.pack(pudelkoJanka);

    // Co jest teraz w wózku Janka...
    // (nie powinno już nic być)
    Console.WriteLine("Po zapakowaniu do pudełka\n" + janek.getShoppingCart());

    // a co w pudełku:
    Console.WriteLine(pudelkoJanka);

    // Zobaczmy jaka jest wartość czerwonych kwiatów w pudełku Janka
    Console.WriteLine("Czerwone kwiaty w pudełku Janka kosztowały: " +
                        pudelkoJanka.valueOf("czerwony"));

    // Teraz przychodzi Stefan
    // ma tylko 60 zł
    Console.WriteLine("Stefan i 60zł");
    Customer stefan = new Customer("Stefan", 60);

    // ąle nabrał kwiatów nieco za dużo jak na tę sumę
    stefan.get(new Lilac(3));
    stefan.get(new Rose(5));

    // co ma w wózku
    Console.WriteLine(stefan.getShoppingCart());

    // płaci i pakuje do pudełka
    stefan.pay();
    Box pudelkoStefana = new Box(stefan);
    stefan.pack(pudelkoStefana);

    // co ostatecznie udało mu się kupić
    Console.WriteLine(pudelkoStefana);
    // ... i ile zostało mu pieniędzy
    Console.WriteLine("Stefanowi zostało : " + stefan.getCash() + " zł");
    Console.ReadKey();
        }
    }
}
