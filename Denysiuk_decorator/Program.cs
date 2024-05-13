using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Denysiuk_decorator;

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();

        var website = new ConcreteComponent();
        Console.WriteLine("Client: I get a regular website:");
        client.ClientCode(website);
        Console.WriteLine();

        // Оптимізуємо вебсайт для мобільних пристроїв
        MobileOptimizedDecorator mobileWebsite = new MobileOptimizedDecorator(website);
        Console.WriteLine("Client: Now I've got a mobile-optimized website:");
        client.ClientCode(mobileWebsite);
    }
}