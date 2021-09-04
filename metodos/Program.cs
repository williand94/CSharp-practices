using System;

namespace metodos
{
    class metodos
    {
        static void Main(string[] args)
        {

            Random numero = new Random();

            int nAleatorio = numero.Next(0,100);
            int intentos = 0;
            System.Console.WriteLine("Ingresa un número por favor!");
            int nIngresado = Int32.Parse(Console.ReadLine());

            while(nAleatorio != nIngresado)
            {
                if(nAleatorio < nIngresado)
                {
                    System.Console.WriteLine("Ingresa un número mas bajo");
                    nIngresado = Int32.Parse(Console.ReadLine());
                } 
                else if (nAleatorio > nIngresado) 
                {
                    System.Console.WriteLine("Ingresa un número mas alto");
                    nIngresado = Int32.Parse(Console.ReadLine());

                }
                intentos ++;
            }    
            System.Console.WriteLine($"EL juego terminó con {intentos} intentos. el número era {nAleatorio}");



           /*  System.Console.WriteLine("Ingresa el mes a calcular");

            int nMes = Int32.Parse(Console.ReadLine());

            switch (nMes)
            {
                case 6:
                    double primas = 0.02;
                    double salario = 900000.90;
                   Console.WriteLine(primas * salario);

                    break;
                default:
                break;
            } */

            /* int valor1 = 5;
            double valor2 = 6.9;
            double valor3 = 8.9;
            Console.WriteLine(suma(valor2,valor1, valor3));  */ 

          /*   string carnet = "no";

            System.Console.WriteLine("Iingresa tu edad");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                System.Console.WriteLine("¿Tienes carnet?");
                carnet = System.Console.ReadLine();
                
            }


            if(edad >= 18 && carnet == "si")

                System.Console.WriteLine("You can Drive");
            else
                System.Console.WriteLine("You don't drive!");

 */
        }
        //static double suma(double a, int b, double c= 4) => a + b + c ;
    
        
    
    
    
    }

}
