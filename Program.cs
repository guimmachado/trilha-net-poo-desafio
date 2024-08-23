using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("123456789");
            nokia.InstalarAplicativo("WhatsApp");

            Iphone iphone = new Iphone("987654321");
            iphone.InstalarAplicativo("Instagram");
        }
    }
}