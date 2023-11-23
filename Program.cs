using System.Globalization;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EstruturaRepetitivaEnquanto
{
    class program
    {
        static void Main(string[] args)
        {
            int x, soma;
            soma = 0;

            x = int.Parse(Console.ReadLine());

            //recomanda - se quando não se sabe ao certo quantas repetições haverá.

            while (x != 0) //enquanto
            {
                soma = soma + x;

                x = int.Parse(Console.ReadLine());


            }
            Console.WriteLine(soma);
            Console.ReadLine();

        }
    }
}