using System;

namespace primeraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int edad = 22;
            if (edad > 18)
            {
                Console.WriteLine("Puedes salir a Follar tienes " + edad);
            }else
            {
                Console.WriteLine("Se queda en casa mi rey");
            } */
/* 
            var age = 22;
            age = 221;
            Console.WriteLine($"Tienes una edad de {age} ");
            
            int a;
            int b;
            int c;

            a = b = c = 17;
            Console.WriteLine($"Printing {c}"); */

            //Conversión explícita
           /*  double temperatura = 33.9;
            Console.WriteLine(temperatura);
            int myTemperatura = (int) temperatura;
            Console.WriteLine(myTemperatura); */
            //Conversión implícita
            //Este tipoi de conversiones no necesita casting, ya que son tipos compatibles
            /* int dinero = 10000000;    

            long myMoney = dinero;

            float cm = 1.96F;

            double altura = cm; */

            /* Console.WriteLine("Ingrese primer número para la operación:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo número para la operación:");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"La suma es: {number1 + number2}"); */
/* 
            const int VALOR = 5;
            const int VALOR1 = 4;

            System.Console.WriteLine("Valor: {0}-{1}",VALOR,VALOR1); 
        */

/*             const double PI = 3.1416;

            System.Console.WriteLine("Ingrese el radio");
            
            double radio = double.Parse(Console.ReadLine());

            //double area = radio * radio * PI;

            double area = Math.Pow(radio,2) * PI;

            System.Console.WriteLine($"El área es : {area}"); */
    
            double calcularArea(double a, double b){

                double result =  a + b;
                


                return result ;

            }

            //Console.ReadLine(calcularArea(3.5,6.0));
            System.Console.WriteLine(calcularArea(3.5,6.0));

        }

    }

}
/* 
namespace secondApp{
    
    class Program{
        static void Main(string[] args){

        }
    }

} */
