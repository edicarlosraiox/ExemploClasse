using System.Globalization;
namespace ExemploRetangulo.Exemplo.Exemplo
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura * 2.0) + (Altura * 2.0);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2.0) + Math.Pow(Altura, 2.0)); 
        }
        
    }
}