using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com peso");
            float peso = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com altura");
            float altura = (float)Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Peso da pessoa:  " + peso);
            Console.WriteLine($"Altura da pessoa:  {altura}");

            float result = peso / (altura * altura);

            if (result < 18)
            {
                Console.WriteLine("Abaixo do Peso");
            }
                else if (result >= 18 && result < 25)
                {
                Console.WriteLine("Peso Normal");
                }
                    else if (result >=25 && result < 30)
                    {
                    Console.WriteLine("Sobrepeso");
                    }
                        else if (result >= 30 && result < 40)
                        {
                        Console.WriteLine("Obesidade");
                        }
                            else
                            {
                            Console.WriteLine("Obesidade Grave");
                            }
        }
    }
}
