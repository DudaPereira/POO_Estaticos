using System;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //classes estáticas não podem ser instanciadas

            //em que momento usamos classes estáticas?
            //quando precisarmos de uma solução que pode servir para qualquer tipo de aplicação

            //em que momento não usamos classes estáticas?
            //quando tivermos objetos/classes que são específicas de um tipo de aplicação
            Console.WriteLine(Math.Pow(2,5));

            Console.WriteLine("Digite um valor: ");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());

            Console.WriteLine(Conversor.ConverterDolarParaReal());
            Console.WriteLine(Conversor.ConverterRealParaDolar());

            Console.WriteLine("Digite um valor: ");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());

            Console.WriteLine(Conversor.ConverterEuroParaReal());
            Console.WriteLine(Conversor.ConverterRealParaEuro());

            //este método tamvém tem que ser static na sua declaração
            Testar();
        }

        static void Testar(){
            
        }
    }
}