// See https://aka.ms/new-console-template for more information
using ConsoleApp11;

Hamburger hamburger = new Hamburger();
Shaurma shaurma = new Shaurma();
hamburger.price = 1000;
shaurma.price = 600;
shaurma.ingridients = "Tomato,Cucumber,Free,Ketchup,Mayoneez,Garlic,Greenary ";
hamburger.ingridients = "Hazard,Garlic,Souses,cheese";
shaurma.IsDiet = false;
hamburger.IsDiet = false;
shaurma.caloria = 100;
hamburger.caloria = 120;
hamburger.size ="medium";
shaurma.size ="medium";

Console.WriteLine("Write 1 for shaurma");
Console.WriteLine("Write 2 for hamburger");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write how many ingridients do you want ");
if (a == 1)
{

    Console.WriteLine(shaurma.ingridients);
    int b = Convert.ToInt32(Console.ReadLine()) ;
    if(b>7)
    {
        Console.WriteLine("There are not so much ingridients");
    }
    shaurma.Caloria(b);
    shaurma.Price(b);
    Console.WriteLine("Claoria:"+shaurma.Caloria(b));
    Console.WriteLine("Size:"+shaurma.size);
    Console.WriteLine("Is diet:"+shaurma.IsDiet);
    Console.WriteLine("Price is:" + shaurma.Price(b));
}
if(a == 2)
{
    Console.WriteLine(hamburger.ingridients);
    int c=Convert.ToInt32(Console.ReadLine()) ;
    if(c>4)
    {
        Console.WriteLine("There are not so much ingridients");
    }
    hamburger.Price(c);
    hamburger.Caloria(c);
    Console.WriteLine("Claoria:"+hamburger.Caloria(c));
    Console.WriteLine("Size:" + hamburger.size);
    Console.WriteLine("Is diet:" + hamburger.IsDiet);
    Console.WriteLine("Price is:"+hamburger.Price(c));
}

