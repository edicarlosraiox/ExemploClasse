using System;
using System.Globalization;
using ExemploRetangulo.Exemplo.Exemplo;

namespace Classe
{
    class Program
    {
        static  void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Retangulo R = new Retangulo();

            Console.WriteLine("Entre com a Largura e Altura do Retangulo:");
            R.Largura = double.Parse(Console.ReadLine(),CI);
            R.Altura = double.Parse(Console.ReadLine(),CI);
           
            Console.WriteLine("Area = " + R.Area().ToString("F2",CI));
            Console.WriteLine("Perimetro = " + R.Perimetro().ToString("F2",CI));
            Console.WriteLine("Diagonal = " + R.Diagonal().ToString("F2",CI));


        }
    }
}

